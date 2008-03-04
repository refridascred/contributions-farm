using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double mean = rate;
            if (mean >= (rate * 2.84))
            {
                mean = mean - (double)43;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span - 5.1)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
