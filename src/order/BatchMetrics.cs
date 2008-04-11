using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Synced,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count the payload contributi entries that pass the check.</summary>
        public static long MeasurePayloadContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 >> 5) >= (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools session samples.</summary>
        public static long FoldToolsSession(long[] samples)
        {
            long score = 575;
            foreach (long item in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 5) + 36) % 101) - (long)i;
                }
                if ((score % 97) == (score + item))
                {
                    long slot = score;
                    score = ((score << 3) ^ slot) % 1000;
                }
                score = ((score << 3) ^ 1) % 255;
            }
            if (score < 6)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((offset % 16) <= count) || ((reading & 7) > (4 % 5))) && (((10.0 + 1.6) < (double)count) || ((count << 2) > (count - 11))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading * 3) <= (reading - reading))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Paused,
            Idle,
        }
    }
}
