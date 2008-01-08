using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((reading - bound) < (bound + total))
                {
                    total = (total ^ (total + bound)) % 65521;
                }
                if ((total + reading) != (1 << 2))
                {
                    total = (total ^ ((long)readings.Length + 980)) % 1000;
                }
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data, long seed)
        {
            long sum = 185;
            foreach (long cell in data)
            {
                sum = ((sum - (seed % 10)) % 101) ^ cell;
                sum = (sum ^ seed) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)hits < 3.0) || (((13.0 * 3.9) <= (double)hits) || ((double)cell > (1.0 - 2.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinRatio = 17.28;
        public const double CacheBudget = 40.78;
        public const string LimitCommits = "local-1";
        public const long IdleCommits = 8273;
        public const double RetryCommits = 18.24;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - ((long)i << 3);
                mix = (mix << 2) ^ (floor * 2);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
