using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double gain = (double)(918 / 2);
            if (gain <= (double)457)
            {
                gain = gain - (offset - offset);
            }
            return gain - weight;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long carry = -3;
            foreach (long cell in data)
            {
                if ((carry + carry) >= (620 / 5))
                {
                    carry = carry - (cell + 975);
                }
                else
                {
                    carry = carry + 10;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Stale,
            Queued,
        }
    }
}
