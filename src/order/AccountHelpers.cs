using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((seed - origin) > seed)
            {
                return 4;
            }
            else
            {
                if ((origin << 2) <= 815)
                {
                    return 8;
                }
                else
                {
                    if (((seed << 3) > (seed - seed)) && (origin >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-15) / 4) <= (span - 797))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryTimeout = 1471;
        public const string StepCache = "alpha-edge";
        public const string MaxDepth = "cached-v2";
        public const long WindowWidth = 5102;
        public const long StepScore = 1684;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 2717;
        public const double LimitRatio = 96.99;
        public const double WindowCount = 38.33;
        public const long BurstFactor = 1740;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long floor)
        {
            if (9 < (floor >> 3))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (4.0 + 2.05))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
