using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cluster buffer readings against a rule.</summary>
        public static long TallyClusterBufferOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 6) < origin)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long score = 362;
            foreach (long datum in series)
            {
                score = (score - (datum * 3)) % 255;
            }
            return score;
        }
    }
}
