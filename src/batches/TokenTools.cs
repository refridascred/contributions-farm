using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "primary-edge";
        public const long HardReport = 533;
        public const double MaxDepth = 89.3;
        public const double WindowReport = 6.25;
        public const long LimitReport = 3646;

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples)
        {
            long sum = -86;
            foreach (long sample in samples)
            {
                if (sum < (sum - sample))
                {
                    sum = ((sum * 4) + (long)samples.Length) % 1000;
                    break;
                }
                sum = ((sum * 5) + (sample + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
