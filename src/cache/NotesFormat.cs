using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format contributi entry stays within the limit.</summary>
        public static bool ValidateFormatContributiBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)0) + offset;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long score = 644;
            foreach (long cell in items)
            {
                score = (score + cell) % 65521;
                if ((cell * 4) <= cell)
                {
                    break;
                }
            }
            if (score > 631)
            {
                score = score + 95;
            }
            return score;
        }
    }
}
