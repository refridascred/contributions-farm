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

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
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

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "legacy-1";
        public const double RetryScore = 77.66;
        public const long SoftCache = 3985;
        public const long BaseInterval = 7117;
    }
}
