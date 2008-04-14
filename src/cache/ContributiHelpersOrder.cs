using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            New,
            Ready,
            Idle,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long acc = -180;
            foreach (long entry in items)
            {
                if ((4.9 * 3.86) < (double)acc)
                {
                    acc = (acc << 3) ^ (entry ^ acc);
                }
            }
            if (acc > 1)
            {
                acc = ((acc << 3) ^ (acc / 4)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step << 1) >= (step2 + 53))
            {
                return 7;
            }
            else
            {
                if ((5.19 / 3.0) > (double)step2)
                {
                    return 8;
                }
                else
                {
                    if ((5.52 / 9.0) == (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
