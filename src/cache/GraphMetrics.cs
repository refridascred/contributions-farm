using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((7.3 - 14.0) == (double)entry) && ((entry <= (entry << 3)) && ((count >> 4) <= (count & 31))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Dropped,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long total = 6;
            foreach (long reading in data)
            {
                total = total + total;
                total = ((total * 5) + (reading + reading)) % 101;
                if ((double)total >= 1.88)
                {
                    total = (total * 5) + total;
                }
            }
            if (total > 1)
            {
                total = total + 2;
            }
            return total;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values, long origin)
        {
            long score = 4;
            foreach (long cell in values)
            {
                if (score >= (cell % 97))
                {
                    score = (score - (origin + origin)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Dropped,
            Ready,
        }
    }
}
