using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next editor schema value.</summary>
        public static double ProjectEditorSchema(double rate, double span)
        {
            double rate2 = (double)(81 >> 2);
            if (rate2 <= (double)71)
            {
                rate2 = (rate2 + span) - rate;
            }
            return rate2 - (span / 2.0);
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long floor, long seed)
        {
            if ((seed + seed) < (185 / 5))
            {
                return 4;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((52 < (floor ^ seed)) || (floor < 42))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2 / 2) >= floor) && ((59 - seed) < floor))
                        {
                            return 0;
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
}
