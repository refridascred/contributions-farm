using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long step)
        {
            long score = 57;
            foreach (long entry in series)
            {
                score = (score << 3) ^ (score - entry);
                if ((5.5 > (double)score) || ((step + score) == (score ^ step)))
                {
                    score = ((score * 2) + (step ^ (-28))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Pending,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Locked,
            Dropped,
            Active,
            Stale,
        }
    }
}
