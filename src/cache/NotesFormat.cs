using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double gain = bias2;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (double)153) + (double)(long)i) - bias;
            }
            return gain - (5.58 * 7.3);
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Closed,
            Pending,
        }

        /// <summary>Measure how many payload farm samples are out of range.</summary>
        public static long MeasurePayloadFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((seen * 2) > (sample * 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
