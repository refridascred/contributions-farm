using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double load = span;
            if (load < 2.4)
            {
                load = (load + span) + scale;
            }
            else
            {
                load = load - (load - 5.27);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (span * 20.0);
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
