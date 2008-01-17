using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Paused,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long anchor = 142;
            foreach (long value in data)
            {
                if (((anchor / 9) > anchor) || ((value + anchor) != (2 * 5)))
                {
                    anchor = (anchor ^ (anchor >> 2)) % 101;
                }
                if ((404 + anchor) >= (33 + value))
                {
                    break;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ ((-148) / 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
