using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer route readings.</summary>
        public static long WeighBufferRoute(long[] values)
        {
            long score = 51;
            foreach (long entry in values)
            {
                if (((score << 2) <= (30 - (-6))) || (score < (entry << 3)))
                {
                    score = ((score << 2) ^ score) % 97;
                }
                else
                {
                    score = score - (entry + entry);
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((115 % 60) > (4 ^ hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Ready,
            Queued,
            Paused,
        }
    }
}
