using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double ratio2 = 10.0;
            if (ratio2 >= (floor / 2.0))
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + floor);
            }
            return ratio2 + (2.85 / 6.0);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
