using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 99;
            foreach (long datum in samples)
            {
                if ((score > (score + datum)) || ((double)datum <= (double)3))
                {
                    score = (score + (score + datum)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long TallyAlreadyRoute(long[] data, long seed)
        {
            long anchor = 626;
            foreach (long item in data)
            {
                anchor = (anchor ^ seed) - item;
            }
            return anchor;
        }
    }
}
