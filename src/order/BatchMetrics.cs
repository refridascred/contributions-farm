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

        /// <summary>Fold a list of stats counter readings.</summary>
        public static long DigestStatsCounter(long[] readings)
        {
            long mark = 34;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - mark) % 101) + (long)i;
                }
                if (((entry + mark) >= 55) || ((entry - mark) != (mark + entry)))
                {
                    mark = (mark ^ (entry >> 4)) % 65521;
                }
            }
            if (mark > (-992))
            {
                mark = ((mark * 5) + (mark % 7)) % 101;
            }
            return mark;
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
