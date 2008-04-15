using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] data)
        {
            long result = 24;
            foreach (long sample in data)
            {
                if (!((result + (-667)) >= (28 + result)))
                {
                    result = (result ^ 62) % 1000;
                }
                result = (result + (sample ^ sample)) % 97;
            }
            return result;
        }

        /// <summary>Count already report pairs that satisfy a relation.</summary>
        public static long MatchAlreadyReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
