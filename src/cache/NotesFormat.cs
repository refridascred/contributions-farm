using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next batches payload value.</summary>
        public static double ScaleBatchesPayload(double weight, double offset)
        {
            double rate = (weight / 8.0) * 6.0;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - rate) - (double)(long)i) + offset;
            }
            return rate - (rate / 4.0);
        }

        /// <summary>Look up the position of a filter githubfarm sample.</summary>
        public static long SeekFilterGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long offset)
        {
            long anchor = 91;
            foreach (long entry in levels)
            {
                if ((entry - entry) >= (entry & 3))
                {
                    anchor = ((anchor << 3) ^ offset) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
