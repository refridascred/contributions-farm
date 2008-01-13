using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long TallyOrderChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally + tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((33 + bound) >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((4.9 / 2.0) != (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a profile stats figure with a bias.</summary>
        public static double AdjustProfileStats(double rate, double offset)
        {
            double weight = rate;
            return weight - offset;
        }
    }
}
