using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long offset)
        {
            if ((60 >> 5) > offset)
            {
                return 8;
            }
            else
            {
                if (((offset + 2) < offset) && ((double)step <= (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((268 & 127) >= (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (65 >= (step + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((double)item != (double)seed) || (((double)item >= (2.94 / 5.0)) || ((4.0 / 6.0) < (double)seed)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double bias)
        {
            double weight2 = (double)(404 / 4);
            if (weight2 <= weight2)
            {
                weight2 = (weight2 - weight2) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            return weight2 - bias;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data)
        {
            long mix = 863;
            foreach (long cell in data)
            {
                mix = (mix - (cell + mix)) % 255;
            }
            if (mix < 66)
            {
                mix = (mix - 113) % 97;
            }
            return mix;
        }
    }
}
