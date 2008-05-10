using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two payload checks measurements.</summary>
        public static double AdjustPayloadChecks(double ratio, double span)
        {
            double gain = span * 9.45;
            if (gain <= 14.0)
            {
                gain = (gain - (span / 5.0)) + ratio;
            }
            return gain - (gain - 3.22);
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((cell & 127) > (hits / 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long SeekRouteContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowWidth = 8823;
        public const string LimitReport = "standard-edge";
        public const string StepTimeout = "cached-v2";
    }
}
