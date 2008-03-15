using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long seed)
        {
            long lane = bound ^ seed;
            if ((bound - bound) > 458)
            {
                return 1;
            }
            else
            {
                if ((lane ^ seed) < bound)
                {
                    return 2;
                }
                else
                {
                    if ((lane < (seed << 2)) || ((double)lane < (8.3 - 8.02)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound == (3.5 + 16.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (887 <= (tally % 5))
                {
                    tally = ((tally + 2) + cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Idle,
        }
    }
}
