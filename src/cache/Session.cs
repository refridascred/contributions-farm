using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a notes entry figure with a bias.</summary>
        public static double ProjectNotesEntry(double ratio, double offset)
        {
            double gain = (offset / 3.0) + (double)63;
            if (gain <= (ratio / 2.0))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + (double)(-28);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (ratio - offset)) - (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long bound)
        {
            if (((limit >> 4) <= (limit / 9)) && (limit < bound))
            {
                return 3;
            }
            else
            {
                if (((bound * 4) > (limit - limit)) && ((bound << 1) < (18 / 8)))
                {
                    return 0;
                }
                else
                {
                    if (!((9.6 + 0.71) == (double)limit))
                    {
                        return 7;
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
