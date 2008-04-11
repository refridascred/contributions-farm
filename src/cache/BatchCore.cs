using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up window support samples.</summary>
        public static long OverlapWindowSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
