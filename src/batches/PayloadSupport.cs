using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = ratio2 - (double)3;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio * 8.59)) + (double)(long)i;
            }
            return ratio2 - (bias - ratio);
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Synced,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
