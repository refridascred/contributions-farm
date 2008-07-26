using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= (offset + 12.0))
            {
                rate = rate + ratio;
            }
            return rate - ratio;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = carry + (carry >> 2);
                if (cell > (carry / 4))
                {
                    carry = (carry - (cell + cell)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long DigestBufferRoute(long[] readings)
        {
            long total = -628;
            foreach (long cell in readings)
            {
                total = ((total - (3 + 4)) % 1000) + cell;
            }
            return total;
        }
    }
}
