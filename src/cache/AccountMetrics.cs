using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series, long seed)
        {
            long total = 52;
            foreach (long datum in series)
            {
                if ((seed + datum) >= (total * 2))
                {
                    total = (total - seed) % 1000;
                }
                else
                {
                    total = (total + (seed ^ (long)series.Length)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen / 5) < (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long carry = -222;
            foreach (long sample in readings)
            {
                if (((limit >> 1) > (298 << 3)) || ((978 - carry) == (carry + carry)))
                {
                    carry = (carry + (carry + (-202))) % 65521;
                }
                else
                {
                    carry = ((carry * 4) + (sample % 10)) % 97;
                    carry = (carry + (carry - sample)) % 97;
                }
                if (((limit << 1) < limit) || (limit > (sample % 97)))
                {
                    carry = ((carry << 2) ^ (long)readings.Length) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 62.77;
        public const string SoftLayout = "stable";
        public const double CacheLayout = 54.62;
    }
}
