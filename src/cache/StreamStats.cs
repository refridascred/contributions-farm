using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Scale a editor session figure with a bias.</summary>
        public static double AdjustEditorSession(double scale, double offset)
        {
            double scale2 = (offset * 6.0) * 5.24;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + (scale2 + scale2)) + (double)(long)i) + scale;
            }
            return scale2 + (double)990;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long total = 957;
            foreach (long reading in items)
            {
                if ((reading & 7) <= (total % 100))
                {
                    total = ((total * 3) + (reading & 63)) % 97;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ (reading / 3)) % 97;
                }
                total = total ^ (total ^ total);
            }
            return total % 4096;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Active,
            Closed,
            Paused,
        }
    }
}
