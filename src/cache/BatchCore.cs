using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (floor + score)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long floor)
        {
            if ((step + step) < (floor ^ 72))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) <= (step + floor))
                {
                    return 1;
                }
                else
                {
                    if ((-506) > (floor << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step == (2.0 - 2.9)) && ((floor ^ 6) > (step + 78)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
