using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long bound)
        {
            long delta = step - bound;
            if (!((step + 8) >= (step + 5)))
            {
                return 3;
            }
            else
            {
                if (((1.4 / 7.0) == (double)bound) || ((double)delta <= (7.8 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if (bound >= delta)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((77 + delta) >= (bound >> 1)) && ((delta + 94) < 94))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long TallyRouteQueueHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (0 >= (cell + cell))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
