using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 17.22;
        public const string MinBatch = "local";
        public const string StepBatch = "alpha-edge";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((hits - item) == (hits ^ 7)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings)
        {
            long result = 0;
            foreach (long item in readings)
            {
                result = (result + (result + item)) % 101;
                if ((4.0 <= (double)item) || (result >= 890))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = ((result * 3) + ((-983) + result)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
