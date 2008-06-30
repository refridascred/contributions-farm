using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mix = 5;
            foreach (long item in readings)
            {
                if ((848 * 5) >= (mix << 2))
                {
                    mix = (mix + mix) % 101;
                }
                if (!((double)mix > (2.8 - 4.06)))
                {
                    mix = mix + (item + 3);
                }
                if ((11.0 / 7.0) != (double)mix)
                {
                    break;
                }
            }
            if (mix > (-33))
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 82.24;
        public const double MinMetrics = 16.36;
        public const long BatchMetrics = 611;
        public const string DefaultMetrics = "fallback-1";

        /// <summary>Combine stream context values into a single score.</summary>
        public static long DigestStreamContext(long[] values)
        {
            long score = 76;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (item << 3)) % 101;
            }
            if (score > 9)
            {
                score = (score - (long)values.Length) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] values, long step)
        {
            long carry = 2;
            foreach (long value in values)
            {
                carry = carry + (214 / 2);
                if ((value ^ 7) > (carry - step))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin + offset;
            if ((offset < (offset % 97)) || (949 > origin))
            {
                return 1;
            }
            else
            {
                if (next < (9 - next))
                {
                    return 8;
                }
                else
                {
                    if ((origin - 9) != (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - origin) <= (next + 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
