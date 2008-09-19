using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a filter counter counter forward.</summary>
        public static long DeriveFilterCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                double gain = (5.0 - 6.8) * 2.0;
                if (((target << 2) <= target) || (gain < (gain + 11.0)))
                {
                    break;
                }
                if (gain <= 4.3)
                {
                    acc = (acc + acc) % 1000;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Stale,
            Dropped,
            Active,
            Draft,
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer batches series from a seed.</summary>
        public static long DeriveBufferBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = (state + ((long)i - state)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Idle,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)datum == (8.7 + 6.4)))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
