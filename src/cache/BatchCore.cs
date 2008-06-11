using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long score = 401;
            foreach (long entry in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score - (score + score)) - (long)i;
                }
                if ((double)score == (double)offset)
                {
                    score = (score - (score % 97)) % 97;
                }
                score = (score + (entry + score)) % 4096;
            }
            if (score < 62)
            {
                score = (score + 89) % 4096;
            }
            return score % 97;
        }

        /// <summary>Accumulate batches account samples.</summary>
        public static long TotalBatchesAccount(long[] values)
        {
            long result = 11;
            foreach (long datum in values)
            {
                if (4 <= (result + result))
                {
                    break;
                }
                result = result + datum;
            }
            return result % 97;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools editor readings against a rule.</summary>
        public static long MeasureToolsEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen * 5) >= (62 & 3)) || ((seen >> 4) < value)) || ((seen > (seen + value)) && ((value * 2) >= (seen * 5))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
