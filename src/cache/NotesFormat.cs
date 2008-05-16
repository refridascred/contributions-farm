using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cluster account value against two limits.</summary>
        public static long SortClusterAccount(long step, long floor)
        {
            long offset = step + floor;
            if (((floor + 0) == (step + floor)) && (offset <= (step ^ offset)))
            {
                return 7;
            }
            else
            {
                if ((floor < 972) && ((double)floor > (0.79 - 7.27)))
                {
                    return 2;
                }
                else
                {
                    if ((floor * 3) <= 232)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((17.0 + 4.9) == (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels, long seed)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total + (datum - total)) + seed;
            }
            if (total < 88)
            {
                total = (total << 3) ^ (500 << 1);
            }
            return total % 65521;
        }
    }
}
