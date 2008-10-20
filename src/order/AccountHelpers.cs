using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Draft,
            Active,
            Queued,
            Idle,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window cluster entries.</summary>
        public static long TallyWindowCluster(long[] readings)
        {
            long mix = 5;
            foreach (long value in readings)
            {
                if ((12.0 + 6.0) > (double)value)
                {
                    mix = ((mix * 2) + mix) % 101;
                }
                else
                {
                    mix = (mix ^ (9 ^ value)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long limit, long step)
        {
            if (limit <= (limit % 5))
            {
                return 2;
            }
            else
            {
                if ((1 <= (704 - limit)) || (494 > step))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (18.0 * 0.5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 8822;
        public const string StepCommits = "standard-1";
        public const double MinCommits = 74.37;
    }
}
