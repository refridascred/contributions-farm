using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double gain = (double)(3 >> 4);
            if (gain <= (double)65)
            {
                gain = (gain + bias) - span;
            }
            else
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long anchor = 81;
            foreach (long cell in values)
            {
                anchor = ((anchor * 2) + (anchor ^ 351)) % 4096;
                if (((8 & 3) <= anchor) || (anchor < (cell / 7)))
                {
                    anchor = (anchor - cell) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
                if ((87 >= (cell - 54)) && ((cell / 8) <= cell))
                {
                    anchor = (anchor << 3) ^ (anchor % 2);
                }
                if ((cell < (anchor << 1)) && (anchor <= (anchor + anchor)))
                {
                    break;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor * 5) + (814 / 7);
            }
            return anchor;
        }
    }
}
