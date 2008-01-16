using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((offset / 8) != (datum + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Retry,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long limit2)
        {
            if (!((limit2 >> 4) == (limit2 + limit2)))
            {
                return 8;
            }
            else
            {
                if ((limit2 * 3) == (limit - limit2))
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit2 << 2) > 7)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
