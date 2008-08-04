using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long step2 = seed - step;
            if (!(step >= (step2 + 89)))
            {
                return 8;
            }
            else
            {
                if ((step + 927) < (step ^ step2))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed >= (3.8 - 12.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = mix + ((long)i2 >> 4);
                }
                mix = (mix - (offset - offset)) % 4096;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowTimeout = "primary-edge";
        public const string CacheDepth = "latest-1";
        public const long MinProfile = 9724;
        public const double LimitProfile = 83.02;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
