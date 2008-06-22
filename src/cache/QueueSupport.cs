using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long origin)
        {
            long score = 7;
            foreach (long entry in series)
            {
                score = ((score + (2 + 510)) % 97) ^ entry;
            }
            if (score < 70)
            {
                score = (score + (origin % 60)) % 4096;
            }
            return score;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double span)
        {
            double ratio = 4.09;
            return ((ratio - ratio) + weight) + span;
        }
    }
}
