using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - anchor) >= 2)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            long span = target - floor;
            if ((double)5 == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((double)target >= (1.77 * 2.91))
                {
                    return 6;
                }
                else
                {
                    if ((double)target <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target < (span + span)) || ((floor / 3) >= span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long result = 861;
            foreach (long item in samples)
            {
                if (!((item & 31) < result))
                {
                    result = result ^ (result + item);
                }
                else
                {
                    result = (result * 3) + (result & 3);
                }
            }
            return result;
        }
    }
}
