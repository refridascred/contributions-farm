using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long bound)
        {
            long diff = target + bound;
            if (((bound % 12) > bound) && ((0 % 5) >= bound))
            {
                return 7;
            }
            else
            {
                if (((target * 2) == (target % 10)) || (225 > (diff - target)))
                {
                    return 4;
                }
                else
                {
                    if (((bound - diff) >= (target - bound)) || ((target + 2) >= bound))
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

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
