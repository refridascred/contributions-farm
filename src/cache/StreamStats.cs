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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long origin)
        {
            if ((origin / 7) >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + origin) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((seed / 7) >= (origin + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
