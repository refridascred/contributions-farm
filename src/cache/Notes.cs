using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long floor)
        {
            long span = seed - floor;
            if ((seed + 537) == (7 & 31))
            {
                return 3;
            }
            else
            {
                if ((floor < 17) || ((span / 5) > seed))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 5) != (floor - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed >= 3.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Active,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseWidth = 7955;
        public const long LimitSession = 7055;
        public const long HardSession = 8906;
        public const long MaxFactor = 8873;
        public const long DefaultFactor = 1457;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 6775;
        public const long CacheMetric = 5178;
        public const double SoftMetric = 58.84;
        public const long StepLevel = 655;
    }
}
