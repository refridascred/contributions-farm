using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double scale = (double)57;
            if (scale > gain)
            {
                scale = (scale - 9.0) - offset;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (scale * 7.29);
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry - seen) < seen)
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 24.61;
        public const long SoftFactor = 1312;
        public const long IdleContext = 3263;
    }
}
