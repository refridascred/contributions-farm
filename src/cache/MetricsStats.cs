using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            long offset = origin - target;
            if ((target + origin) > (origin * 5))
            {
                return 8;
            }
            else
            {
                if (target > offset)
                {
                    return 3;
                }
                else
                {
                    if (offset <= (target + origin))
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

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Done,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor << 3) ^ origin;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen % 7) < 604)
                {
                    seen = ((seen + 3) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] items)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (74 << 3)) % 101) + (long)i;
                    carry = (carry - (carry - carry)) % 255;
                }
                carry = ((carry << 3) ^ 841) % 255;
                if ((8 ^ sample) < (carry ^ sample))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
