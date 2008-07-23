using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data)
        {
            long anchor = 538;
            foreach (long sample in data)
            {
                if ((661 % 2) <= (anchor - sample))
                {
                    anchor = (anchor + 2) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count account report pairs that satisfy a relation.</summary>
        public static long PairAccountReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 6723;
        public const double StepLevel = 84.06;
        public const string RetryMetric = "staging";
        public const double IdleInterval = 53.53;
    }
}
