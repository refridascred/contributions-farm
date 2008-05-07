using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double load = ratio / 2.0;
            if (load > (span + span))
            {
                load = load - (12.0 + load);
            }
            else
            {
                load = load + (ratio - ratio);
            }
            return load - (load * 4.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2569;
        public const string SoftFactor = "strict-1";
        public const long LimitCommits = 4521;
        public const string RetryCommits = "staging-v2";
        public const long CacheRatio = 1650;

        /// <summary>Fold a list of metrics profile readings.</summary>
        public static long TallyMetricsProfile(long[] series, long target)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = (mix ^ (target - mix)) + reading;
                mix = (mix << 3) ^ 369;
            }
            if (mix > 51)
            {
                mix = (mix - (target - 881)) % 97;
            }
            return mix % 1000;
        }
    }
}
