using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

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
