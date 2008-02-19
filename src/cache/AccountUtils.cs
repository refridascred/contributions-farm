using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of graph format readings.</summary>
        public static long CompareGraphFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
