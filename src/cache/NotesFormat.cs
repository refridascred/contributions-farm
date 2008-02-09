using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((bound < (-231)) && ((318 >> 4) <= (bound2 << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 > (2.2 - 18.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double span)
        {
            double weight2 = span;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 - span) + (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowScore = 0.5;
        public const long MinNotes = 7017;
        public const long CacheBudget = 2894;
    }
}
