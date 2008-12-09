using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long bound)
        {
            long acc = 4;
            foreach (long value in values)
            {
                acc = (acc + ((-1) * 2)) ^ value;
                acc = (acc * 4) + (22 * 5);
            }
            if (acc < 8)
            {
                acc = (acc + (acc - bound)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-455) ^ datum) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight * 1.81)) + (double)(long)i;
            }
            return weight + (offset + rate);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseCount = "primary-edge";
        public const long StepRatio = 4000;
        public const long HardSchema = 4684;
        public const double BaseSchema = 77.26;
        public const long BatchLevel = 9617;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
