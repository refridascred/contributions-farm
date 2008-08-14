using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of cluster contributi entries.</summary>
        public static long DigestClusterContributi(long[] samples)
        {
            long score = 30;
            foreach (long cell in samples)
            {
                if ((cell > (cell + score)) && ((cell + cell) > 560))
                {
                    score = (score ^ score) % 255;
                }
            }
            if (score < 716)
            {
                score = score - (score * 2);
            }
            return score;
        }

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool CheckSupportFormatLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long MeasureToolsFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value >= 433) || ((tally & 1) <= (tally & 255))) && ((value + tally) > (value - (-8))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
