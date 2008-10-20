using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double mean = gain;
            if (mean < (gain - gain))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain * 5.94)) + (double)(long)i;
            }
            return mean - 19.0;
        }

        /// <summary>Rank stream channel input into a small class.</summary>
        public static long ClassifyStreamChannel(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if (!((double)bound2 <= (18.0 / 9.0)))
            {
                return 8;
            }
            else
            {
                if ((81 + offset) >= bound2)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Dropped,
            Active,
            Queued,
            Locked,
        }
    }
}
