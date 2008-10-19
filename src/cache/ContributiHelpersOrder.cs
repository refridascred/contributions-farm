using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long target)
        {
            if (target > ((-69) >> 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.4 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Ready,
            Done,
            New,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor + 535) >= (floor - score))
                {
                    score = (score + (score + score)) % 97;
                }
                else
                {
                    score = score - (floor ^ (long)i);
                }
                score = (score + (floor - (long)i)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
