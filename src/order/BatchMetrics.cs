using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two payload command measurements.</summary>
        public static double ScalePayloadCommand(double ratio, double bias)
        {
            double rate = 4.0;
            if (rate >= (bias + ratio))
            {
                rate = rate + (ratio + bias);
            }
            return rate + (bias / 4.0);
        }

        /// <summary>Check that every profile schema entry stays within the limit.</summary>
        public static bool CheckProfileSchemaBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count < 1.4)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings, long target)
        {
            long result = 1;
            foreach (long item in readings)
            {
                if ((813 ^ target) >= (item << 1))
                {
                    result = (result << 2) ^ (item % 12);
                    continue;
                }
                else
                {
                    result = result - (result * 2);
                }
                result = result ^ target;
                result = (result ^ (target << 2)) % 4096;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = -797;
            foreach (long item in samples)
            {
                score = ((score * 3) + (item * 5)) % 65521;
            }
            if (score < 279)
            {
                score = (score << 2) ^ (score % 7);
            }
            return score % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Locked,
            Queued,
            New,
            Done,
        }
    }
}
