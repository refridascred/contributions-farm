using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "strict-v2";
        public const string BatchCommand = "strict";
        public const double LimitWidth = 86.26;
        public const long MinCommand = 6170;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor * 2) + (anchor - (long)i);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryLevel = "local-v2";
        public const string MinScore = "latest";
        public const string DefaultTimeout = "alpha-edge";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((4.3 + 8.5) >= (double)datum) || ((double)matches > (double)datum))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long target)
        {
            if ((origin + origin) <= origin)
            {
                return 3;
            }
            else
            {
                if ((29 + target) > (target + 95))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
