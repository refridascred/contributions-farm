using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardBudget = 1.85;
        public const long LimitFactor = 7525;
        public const string WindowSize = "legacy-v2";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long target)
        {
            if (((double)floor > (19.0 - 5.0)) && (87 < (target - target)))
            {
                return 6;
            }
            else
            {
                if ((floor + target) > 76)
                {
                    return 4;
                }
                else
                {
                    if ((target & 7) <= (floor & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data, long bound)
        {
            long state = 643;
            foreach (long entry in data)
            {
                if ((bound & 15) == (entry % 7))
                {
                    state = state + (bound + 1);
                }
                else
                {
                    state = (state ^ (bound & 255)) % 1000;
                }
            }
            if (state < 4)
            {
                state = (state - ((-224) * 2)) % 101;
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Retry,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
