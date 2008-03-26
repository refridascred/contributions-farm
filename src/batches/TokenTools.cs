using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (state << 3)) % 97;
                if ((double)reading <= 9.1)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if (((target + 702) < (target / 5)) && ((origin - origin) <= (target ^ target)))
            {
                return 4;
            }
            else
            {
                if ((target & 7) < target)
                {
                    return 3;
                }
                else
                {
                    if (target >= (origin + 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (12.0 + 2.55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
