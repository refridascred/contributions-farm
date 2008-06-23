using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a filter stream reading.</summary>
        public static double ProjectFilterStream(double weight, double offset)
        {
            double rate = (weight - weight) + (double)8;
            if (rate >= 6.1)
            {
                rate = rate - (double)251;
            }
            else
            {
                rate = rate - 7.03;
            }
            return rate + (weight - offset);
        }
    }
}
