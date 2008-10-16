using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long offset)
        {
            long lane = seed - offset;
            if (((seed + 977) <= 368) && ((seed + offset) >= (lane ^ lane)))
            {
                return 0;
            }
            else
            {
                if ((seed + offset) >= (offset % 5))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 97) >= (seed * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 2) > (seed * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
