using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 1592;
        public const double BatchBudget = 69.93;
        public const string WindowQueue = "staging";
        public const long BaseQueue = 9765;
        public const long BatchQueue = 3214;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Dropped,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TallyPayloadStats(long[] samples)
        {
            long sum = -5;
            foreach (long entry in samples)
            {
                sum = sum ^ (entry + entry);
                if (entry >= (sum >> 5))
                {
                    sum = (sum - (entry + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
