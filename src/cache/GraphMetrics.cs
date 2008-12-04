using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank buffer stream input into a small class.</summary>
        public static long ClassifyBufferStream(long step, long bound)
        {
            if (((7.16 - 4.37) == (double)bound) && (((-943) - step) >= (bound - 15)))
            {
                return 2;
            }
            else
            {
                if (!((3.0 / 4.0) == (double)bound))
                {
                    return 8;
                }
                else
                {
                    if ((60 < (bound - bound)) || ((step & 3) != (bound ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = (floor - weight) + floor;
            if (ratio > weight)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.0 - floor)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
