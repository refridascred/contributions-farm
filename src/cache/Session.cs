using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every layout checks entry stays within the limit.</summary>
        public static bool GuardLayoutChecksBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score ^ ((long)i + entry)) % 97;
                }
                if (36 < entry)
                {
                    score = score + 4;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long step)
        {
            if (((8.17 / 5.0) != (double)step) || ((offset % 2) <= 613))
            {
                return 8;
            }
            else
            {
                if (offset < (step & 63))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > (7.12 / 8.0)) || ((step + 986) < (offset + (-75))))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset ^ offset) >= (step - 81)) && (step < (offset - step)))
                        {
                            return 4;
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
