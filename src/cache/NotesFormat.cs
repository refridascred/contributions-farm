using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double rate = (bias + 8.0) + (bias + 7.6);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (double)(-9)) + (double)(long)i) - bias2;
            }
            return rate + rate;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
