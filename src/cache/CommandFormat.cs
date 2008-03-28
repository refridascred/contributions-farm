using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 + (gain2 + floor)) + (double)(long)i) - gain;
            }
            return gain2 - (gain2 * 7.6);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Done,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Count the support context entries that pass the check.</summary>
        public static long AuditSupportContextOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) == (4 + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
