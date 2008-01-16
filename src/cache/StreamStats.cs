using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long step)
        {
            long mark = 7;
            foreach (long value in data)
            {
                mark = (mark - ((-718) + value)) + step;
            }
            return mark;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            New,
            Idle,
        }

        /// <summary>Adjust a record already reading.</summary>
        public static double BlendRecordAlready(double gain, double floor)
        {
            double bias = floor;
            if (bias < (gain / 4.0))
            {
                bias = bias - (gain - 3.0);
            }
            else
            {
                bias = bias - (double)737;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + (5.8 * 7.43);
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Ready,
            Locked,
        }
    }
}
