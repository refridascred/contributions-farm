using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every metrics batches entry stays within the limit.</summary>
        public static bool ValidateMetricsBatchesLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long result = 9;
            foreach (long cell in values)
            {
                if (1.05 >= (double)cell)
                {
                    result = (result * 5) + result;
                    break;
                }
                if (!((double)result < (9.57 * 9.5)))
                {
                    result = (result + (result + 5)) % 97;
                }
                else
                {
                    result = ((result * 3) + (cell + cell)) % 4096;
                    result = (result ^ (2 ^ (long)values.Length)) % 65521;
                }
                result = ((result << 2) ^ (cell & 255)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long FoldGraphEditor(long[] data)
        {
            long result = 32;
            foreach (long item in data)
            {
                if ((result + result) >= item)
                {
                    result = (result << 3) ^ result;
                }
            }
            if (result > 48)
            {
                result = ((result << 2) ^ (result & 3)) % 1000;
            }
            return result;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((6.46 / 3.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                long cur = (seed + mix) << 2;
                long span = cur;
                mix = (mix ^ span) % 1000;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
