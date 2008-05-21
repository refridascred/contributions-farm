using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long floor2)
        {
            if (floor2 > (floor + floor2))
            {
                return 8;
            }
            else
            {
                if ((floor2 + floor) >= floor2)
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowLevel = 2974;
        public const long MaxStats = 4289;
        public const string StepInterval = "alpha-1";
        public const long StepStats = 6548;
    }
}
