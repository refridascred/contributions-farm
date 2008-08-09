using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict-edge";
        public const double StepWidth = 36.61;
        public const double BaseInterval = 41.27;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(item <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long origin)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((reading - 0) < (reading - reading))
                {
                    mark = (mark ^ (origin + origin)) % 101;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (origin >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinInterval = "cached-v2";
        public const long RetryOrder = 6946;
        public const string HardScore = "strict-1";
        public const string SoftOrder = "strict-edge";

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
