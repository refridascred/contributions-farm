using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long step)
        {
            long offset = floor - step;
            if (((offset % 8) > (step & 3)) || ((double)3 >= (double)step))
            {
                return 6;
            }
            else
            {
                if (((offset + step) < step) && ((double)offset >= (18.0 * 9.94)))
                {
                    return 2;
                }
                else
                {
                    if ((step - floor) < (offset + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine command metric values into a single score.</summary>
        public static long FoldCommandMetric(long[] series, long limit)
        {
            long state = 96;
            foreach (long datum in series)
            {
                if ((state + limit) < (datum & 31))
                {
                    state = state - (datum << 2);
                }
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Synced,
            Draft,
            Ready,
            Closed,
        }
    }
}
