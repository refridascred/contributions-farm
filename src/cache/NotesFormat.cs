using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double scale = bias2;
            if (scale >= (15.0 + bias2))
            {
                scale = (scale + (double)27) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (double)958) - (double)(long)i;
            }
            return scale + (double)182;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long edge = step - offset;
            if ((5 >> 4) < (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if (!((double)edge <= (14.0 / 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
