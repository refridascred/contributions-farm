using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items, long origin)
        {
            long carry = 0;
            foreach (long item in items)
            {
                carry = ((carry + carry) % 4096) - origin;
                carry = carry + item;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit >> 3) < sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long floor)
        {
            if (floor < (offset / 8))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (7.55 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if ((0.5 < (double)offset) && ((floor % 100) == (offset ^ offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor < (385 + offset)) && ((double)floor >= (6.85 / 5.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
