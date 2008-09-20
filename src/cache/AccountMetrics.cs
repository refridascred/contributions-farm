using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of stream report readings.</summary>
        public static long OverlapStreamReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats buffer readings.</summary>
        public static long FoldStatsBuffer(long[] data, long origin)
        {
            long result = 7;
            foreach (long cell in data)
            {
                if ((result * 4) < (result / 5))
                {
                    result = ((result * 3) + 7) % 65521;
                }
                result = (result + cell) % 101;
                if (((cell + 21) != (result << 2)) && ((result & 1) < (cell + origin)))
                {
                    break;
                }
            }
            if (result < 334)
            {
                result = (result ^ origin) % 101;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinTimeout = "alpha-1";
        public const long RetryCount = 4690;
        public const double WindowWidth = 20.27;
        public const long BatchLevel = 8519;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 744;
        public const long IdleBudget = 9509;
        public const long LimitAccount = 8962;
    }
}
