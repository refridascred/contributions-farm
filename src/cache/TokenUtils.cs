using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (bound + 26))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema metric samples are out of range.</summary>
        public static long MeasureSchemaMetricMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value << 1) > (value / 9)) || ((value & 127) <= value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches counter samples.</summary>
        public static long WeighBatchesCounter(long[] samples)
        {
            long score = 8;
            foreach (long value in samples)
            {
                score = ((score * 4) + ((long)samples.Length - 509)) - value;
                score = score ^ score;
            }
            return score;
        }
    }
}
