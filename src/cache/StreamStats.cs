using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate notes format samples.</summary>
        public static long TallyNotesFormat(long[] values)
        {
            long state = 43;
            foreach (long value in values)
            {
                if (state < value)
                {
                    state = state - (state * 4);
                }
                state = (state - (0 >> 5)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((3.9 + 2.1) <= (double)cell) && ((double)seen <= (2.25 + 1.16))) || (((seen ^ 508) != (cell ^ seen)) || ((cell - seen) > cell)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
