using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first profile checks entry that matches the target.</summary>
        public static long LookupProfileChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Locate a cluster session reading by value.</summary>
        public static long LocateClusterSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Locked,
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long bound)
        {
            if ((double)bound > (0.14 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) <= 43)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed >= (4.31 * 2.59))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((51 % 24) > (bound << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
