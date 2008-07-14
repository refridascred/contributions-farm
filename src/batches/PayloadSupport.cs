using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Paused,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double load = (gain + gain) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)(-999)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 4) <= ((long)items.Length << 3))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
