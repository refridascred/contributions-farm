using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine schema cluster values into a single score.</summary>
        public static long WeighSchemaCluster(long[] samples)
        {
            long acc = 81;
            foreach (long value in samples)
            {
                if (!((acc - acc) >= (value ^ acc)))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                    acc = (acc << 2) ^ (value - value);
                }
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen - seen) >= limit)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Match up metric already samples.</summary>
        public static long CompareMetricAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4364;
        public const long StepWidth = 6366;
        public const double WindowLevel = 4.78;

        /// <summary>Check that every filter record entry stays within the limit.</summary>
        public static bool CheckFilterRecordRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format session readings.</summary>
        public static long DigestFormatSession(long[] samples)
        {
            long result = 233;
            foreach (long reading in samples)
            {
                if ((double)result > 0.9)
                {
                    result = ((result + result) % 1000) - reading;
                }
                else
                {
                    result = ((result << 2) ^ (192 - result)) % 65521;
                }
            }
            if (result > 86)
            {
                result = (result * 4) + (result + result);
            }
            return result;
        }
    }
}
