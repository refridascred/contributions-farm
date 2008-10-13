using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (7 < (datum >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data, long target)
        {
            long score = 46;
            foreach (long sample in data)
            {
                if ((725 / 7) >= (target ^ score))
                {
                    score = (score ^ (sample % 2)) % 1000;
                }
            }
            return score;
        }
    }
}
