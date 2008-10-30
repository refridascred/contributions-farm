using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((-187) <= (score << 1)) && ((long)i == (floor + (long)i)))
                {
                    score = ((score << 2) ^ (1 + floor)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) >= entry)
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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Pending,
            Closed,
            Synced,
        }
    }
}
