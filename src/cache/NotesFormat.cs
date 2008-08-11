using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account tools figure with a bias.</summary>
        public static double BlendAccountTools(double ratio, double offset)
        {
            double gain = ratio - (ratio + offset);
            if (gain <= (gain - offset))
            {
                gain = gain + (offset * 19.0);
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            return gain + (gain - ratio);
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - step) < (cell >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
