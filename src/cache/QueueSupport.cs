using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long score = 634;
            foreach (long datum in data)
            {
                if ((double)score < 3.48)
                {
                    score = (score + datum) % 97;
                }
            }
            if (score < 0)
            {
                score = score - floor;
            }
            return score;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Grade a entry already value against two limits.</summary>
        public static long RankEntryAlready(long bound, long limit)
        {
            if ((8.24 * 1.81) == (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound > (limit + 269)) || ((bound >> 5) >= (limit << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
