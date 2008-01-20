using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6606;
        public const long BurstScore = 4076;
        public const long BurstSpan = 9461;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Stale,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Find the first route support entry that matches the target.</summary>
        public static long LocateRouteSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi stats pair into a bucket.</summary>
        public static long ClassifyContributiStats(long floor, long seed)
        {
            if ((-56) >= (floor << 3))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) != (seed + floor)) || ((1.0 + 17.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= (seed + 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 89.67;
        public const string BaseScore = "alpha-1";
        public const long BaseSize = 8865;
        public const string DefaultEditor = "local-edge";
    }
}
