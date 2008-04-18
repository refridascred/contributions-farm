using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate metric layout readings against a bound.</summary>
        public static bool ValidateMetricLayoutRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload metrics readings.</summary>
        public static long DigestPayloadMetrics(long[] readings)
        {
            long carry = 47;
            foreach (long datum in readings)
            {
                carry = (carry - datum) % 255;
                if (!(carry >= (datum + datum)))
                {
                    carry = carry ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
