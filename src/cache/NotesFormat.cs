using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long bound, long bound2)
        {
            if (((bound2 * 4) <= (bound + bound)) && ((bound / 4) > (66 & 127)))
            {
                return 5;
            }
            else
            {
                if (!((bound - 99) < (bound % 60)))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound2 != (8.6 + 0.2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)0) + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
