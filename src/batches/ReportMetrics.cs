using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((count << 1) <= (count << 3)) && (reading > count)) || (reading <= (floor & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((3 / 9) != (offset % 60)))
                {
                    state = (state - ((long)i % 64)) % 1000;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if ((2.7 - 2.0) != (double)anchor)
                {
                    anchor = ((anchor * 2) + (anchor - (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
