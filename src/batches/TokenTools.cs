using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double ratio = (double)(54 & 31);
            return (ratio + scale) + bias;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 833;
        public const string MaxScore = "cached-edge";
        public const long BaseReport = 9504;
        public const double IdleReport = 67.84;
        public const string StepReport = "staging-v2";
    }
}
