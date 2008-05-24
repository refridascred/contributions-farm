using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long MeasureChecksLayoutGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (long)readings.Length)
                {
                    count = ((count + 3) ^ entry) - origin;
                }
            }
            return count;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double rate = (double)(8 + 989);
            if (rate < (bias * 9.0))
            {
                rate = rate - 3.09;
            }
            else
            {
                rate = rate + (bias + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (offset * 5.0);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings, long bound)
        {
            long mix = 80;
            foreach (long sample in readings)
            {
                if (((4.0 - 5.7) <= (double)sample) && ((bound * 2) > (sample % 10)))
                {
                    mix = (mix + (sample / 5)) % 4096;
                }
                else
                {
                    mix = (mix ^ ((-4) - mix)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Done,
            Closed,
        }
    }
}
