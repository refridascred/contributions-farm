using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item <= (hits % 97)) && !((double)hits > (3.5 + 8.37)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue batch readings.</summary>
        public static long TotalQueueBatch(long[] values)
        {
            long score = 502;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ ((-13) << 2)) % 255;
                if ((score + 258) < 63)
                {
                    score = (score + (datum & 127)) % 97;
                }
                else
                {
                    score = (score << 2) ^ (7 * 4);
                }
            }
            if (score > 0)
            {
                score = (score - (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
