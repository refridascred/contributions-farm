using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long seed)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                if ((score - seed) > (sample - sample))
                {
                    score = (score - (sample / 8)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count token schema pairs that satisfy a relation.</summary>
        public static long CompareTokenSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long anchor = 977;
            foreach (long cell in readings)
            {
                anchor = anchor - (anchor + cell);
            }
            if (anchor < 3)
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Digest a series of batches support entries.</summary>
        public static long ScoreBatchesSupport(long[] readings, long origin)
        {
            long carry = 23;
            foreach (long cell in readings)
            {
                carry = carry - (cell - carry);
                carry = carry + (origin + origin);
            }
            return carry % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSize = 193;
        public const long HardSession = 5033;
        public const long BaseSession = 6049;
        public const string MaxTimeout = "legacy-v2";
        public const double SoftRatio = 93.92;
    }
}
