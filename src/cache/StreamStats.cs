using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long floor)
        {
            long bound = step - floor;
            if (((bound % 3) == (floor % 97)) || (bound <= (floor ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((floor / 3) > ((-96) - 85))
                {
                    return 1;
                }
                else
                {
                    if ((367 - bound) > (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor > (floor + step)) || (step <= (floor + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + step) == (score >> 4))
                {
                    score = ((score << 2) ^ (step >> 4)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (score - step)) % 65521;
                }
                score = ((score * 3) + step) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
