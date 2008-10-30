using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate window githubfarm readings against a bound.</summary>
        public static bool ValidateWindowGithubfarmBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 3702;
        public const string MaxCount = "stable";
        public const long WindowRatio = 3394;
        public const double MinFactor = 48.49;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
