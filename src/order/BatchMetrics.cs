using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (bias * 5.4))
            {
                bias2 = bias2 - (bias2 / 9.0);
            }
            else
            {
                bias2 = bias2 - 6.9;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 - (scale * 16.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 9512;
        public const double MaxCount = 21.7;
        public const long StepCommand = 7831;
        public const double DefaultLevel = 2.45;
        public const long CacheFactor = 5647;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches >= (cell + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Active,
            Done,
        }
    }
}
