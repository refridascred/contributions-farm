using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format command input into a small class.</summary>
        public static long SortFormatCommand(long origin, long floor)
        {
            if ((1.6 - 8.12) > (double)floor)
            {
                return 5;
            }
            else
            {
                if (((8.12 / 4.0) != (double)floor) || (6.06 >= (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (floor <= 694)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor % 5) >= floor)
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

        /// <summary>Validate stream cache readings against a bound.</summary>
        public static bool VerifyStreamCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double ratio = 9.81;
            if (ratio < (double)79)
            {
                ratio = ((ratio + (2.25 * 20.0)) - scale) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 5.89);
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (20.0 >= (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
