using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the counter commits series from a seed.</summary>
        public static long IterateCounterCommits(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                long seen = score;
                score = (score - (floor + seen)) % 97;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultFactor = "legacy-1";
        public const long StepLevel = 2755;
        public const long BurstFactor = 10;
        public const long SoftContext = 8923;
        public const long MaxContext = 8213;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long floor)
        {
            long delta = limit + floor;
            if (((5.53 / 5.0) == (double)limit) && (limit <= (floor & 1)))
            {
                return 3;
            }
            else
            {
                if ((limit + 0) > (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 5) != (delta + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + floor) != (limit ^ limit))
                        {
                            return 6;
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
