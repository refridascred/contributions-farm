using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            New,
            Closed,
            Ready,
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double SmoothQueueReport(double gain, double floor)
        {
            double ratio = gain + (gain * 7.97);
            if (ratio >= (floor / 6.0))
            {
                ratio = ratio + (floor * 7.76);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 9.0) + (double)(long)i;
            }
            return ratio + (double)(-11);
        }
    }
}
