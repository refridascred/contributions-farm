using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token graph samples are out of range.</summary>
        public static long CountTokenGraphOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum % 97) > (5 + count))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Dropped,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples)
        {
            long score = 106;
            foreach (long sample in samples)
            {
                if ((double)sample < 9.8)
                {
                    score = score - (sample + score);
                }
            }
            if (score > 70)
            {
                score = (score + (score % 5)) % 101;
            }
            return score;
        }
    }
}
