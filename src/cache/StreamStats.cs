using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] series, long bound)
        {
            long sum = 95;
            foreach (long item in series)
            {
                if (!((2 + item) <= sum))
                {
                    sum = sum + bound;
                }
            }
            if (sum < 773)
            {
                sum = (sum ^ (514 >> 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score + 70) ^ (long)i2;
                }
                score = ((score * 3) + (origin + origin)) % 101;
                score = ((score << 3) ^ ((long)i ^ 14)) % 65521;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
