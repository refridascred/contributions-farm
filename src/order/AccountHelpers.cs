using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseRatio = "open-edge";
        public const double CacheGithubfarm = 46.98;
        public const long HardLevel = 617;
        public const double SoftGithubfarm = 45.59;

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double span)
        {
            double drift = 3.8;
            if (drift < (9.33 + span))
            {
                drift = drift + (double)48;
            }
            else
            {
                drift = drift + (scale + span);
            }
            return drift - (double)965;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Active,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long offset)
        {
            if ((offset >> 3) < (target * 3))
            {
                return 3;
            }
            else
            {
                if (((offset - offset) <= (target & 63)) || ((10.0 + 0.48) > (double)target))
                {
                    return 4;
                }
                else
                {
                    if (((3.67 * 18.0) != (double)target) || ((43 & 127) > (target ^ target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset >> 5) >= (offset & 15))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
