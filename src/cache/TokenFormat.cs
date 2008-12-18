using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long result = 146;
            foreach (long datum in levels)
            {
                if (!((double)result <= (1.0 - 2.4)))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = (result << 3) ^ (datum - result);
                }
                if (datum >= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long seed)
        {
            long delta = floor + seed;
            if ((delta <= (6 - 869)) && ((seed % 12) > (delta / 6)))
            {
                return 8;
            }
            else
            {
                if ((seed < (floor ^ floor)) && ((delta + floor) > (delta & 1)))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 31) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor * 5) > ((-37) * 3)) && ((4.44 * 3.5) < (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
