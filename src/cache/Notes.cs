using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((sample + sample) <= (sample >> 3)) || (sample > hits)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "primary-1";
        public const long RetryContributi = 2899;
        public const long MaxContributi = 7211;
        public const double BatchInterval = 73.11;

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 239;
        public const long BaseTools = 1872;
        public const long BatchSize = 9494;

        /// <summary>Count contributi profile pairs that satisfy a relation.</summary>
        public static long OverlapContributiProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                if ((sum - cell) > (cell + sum))
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }
    }
}
