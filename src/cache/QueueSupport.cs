using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels, long origin)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                if ((carry >> 2) > origin)
                {
                    carry = (carry + (origin - origin)) % 255;
                    carry = carry - origin;
                }
                if ((double)reading <= (7.0 / 8.0))
                {
                    carry = ((carry * 5) + (carry % 10)) % 255;
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 4) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double scale = (double)3 * 0.4;
            if (scale >= rate)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 0.81;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (double)885;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
