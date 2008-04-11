using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings, long target)
        {
            long carry = 91;
            foreach (long reading in readings)
            {
                if ((double)carry != (6.0 + 8.25))
                {
                    carry = (carry - carry) ^ reading;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 4) + (carry - target)) % 255;
            }
            return carry;
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
