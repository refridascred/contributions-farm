using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double mean = (double)898 * 5.1;
            if (mean >= (mean - scale))
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - (double)2;
            }
            return mean + (span + mean);
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series, long target)
        {
            long score = 53;
            foreach (long cell in series)
            {
                if (((double)target <= (double)score) || (target < (cell >> 4)))
                {
                    score = (score - 36) % 1000;
                }
                else
                {
                    score = ((score * 4) + (score ^ cell)) % 255;
                }
            }
            return score % 1000;
        }
    }
}
