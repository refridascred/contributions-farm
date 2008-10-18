using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long target)
        {
            long result = 360;
            foreach (long datum in readings)
            {
                result = (result * 4) + (target ^ datum);
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
