using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window batch entries.</summary>
        public static long TallyWindowBatch(long[] samples, long seed)
        {
            long state = 8;
            foreach (long item in samples)
            {
                if ((seed & 31) == (item & 7))
                {
                    state = (state << 3) ^ (7 + 394);
                }
            }
            return state % 97;
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
