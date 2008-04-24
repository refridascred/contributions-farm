using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long step)
        {
            long cur = target ^ step;
            if (cur >= target)
            {
                return 0;
            }
            else
            {
                if (((double)cur >= 14.0) && ((step & 7) >= (1 + 7)))
                {
                    return 5;
                }
                else
                {
                    if (target > (step + 94))
                    {
                        return 1;
                    }
                    else
                    {
                        if (81 <= (target - cur))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long CountStatsCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((-9) >= (tally + tally))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token filter samples.</summary>
        public static long DigestTokenFilter(long[] items)
        {
            long result = 40;
            foreach (long value in items)
            {
                if ((493 ^ value) >= (value - result))
                {
                    result = ((result * 4) + (value + result)) % 65521;
                }
                else
                {
                    result = result ^ ((-351) >> 1);
                }
                if (value < (3 - result))
                {
                    break;
                }
            }
            if (result < (-59))
            {
                result = result + (179 - result);
            }
            return result % 65521;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ ((long)i & 127);
                if (((anchor + (long)i) >= anchor) || ((4.4 * 10.0) > (double)(long)i))
                {
                    anchor = (anchor - (long)i) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
