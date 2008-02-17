using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-1";
        public const string HardCount = "local-v2";
        public const long SoftBudget = 2310;
        public const long IdleBudget = 1296;
        public const long LimitScore = 5292;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series)
        {
            long carry = 877;
            foreach (long datum in series)
            {
                if ((datum - 188) < (datum % 16))
                {
                    carry = ((carry * 5) + (6 + datum)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ ((-4) & 1)) % 65521;
                }
                if ((datum - datum) > datum)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
