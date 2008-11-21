using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many schema commits samples are out of range.</summary>
        public static long AuditSchemaCommitsMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count != (double)item)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9876;
        public const long WindowInterval = 5652;
        public const long BatchScore = 6843;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels)
        {
            long total = 75;
            foreach (long reading in levels)
            {
                if ((total - (long)levels.Length) != (9 + reading))
                {
                    total = ((total * 4) + (reading - total)) % 97;
                }
                else
                {
                    total = (total ^ (144 % 8)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Adjust a already order reading.</summary>
        public static double ScaleAlreadyOrder(double weight, double span)
        {
            double mean = (double)(-8) + (weight + span);
            if (mean > (weight * 0.29))
            {
                mean = mean + (weight + mean);
            }
            return mean + mean;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
