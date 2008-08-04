using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long offset)
        {
            long step = bound + offset;
            if (!((double)step > (0.4 / 2.0)))
            {
                return 4;
            }
            else
            {
                if (bound < (479 % 8))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) == (offset ^ offset)) && (step > (offset >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >> 2) == (bound % 12))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long CountProfileSessionGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((952 / 2) >= tally)
                {
                    tally = ((tally + 3) ^ value) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc + seed) % 1000;
                acc = (acc ^ ((-4) + 493)) % 1000;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool VerifyFilterGraphRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
