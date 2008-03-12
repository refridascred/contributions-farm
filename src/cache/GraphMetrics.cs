using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen <= (9.64 - 11.0))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstScore = 8.3;
        public const string MaxAlready = "alpha";
        public const long MinFactor = 2631;

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6976;
        public const string DefaultTools = "primary";
        public const long StepSize = 4801;
    }
}
