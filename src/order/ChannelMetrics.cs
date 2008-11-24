using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Done,
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long offset)
        {
            if ((origin + offset) < (offset << 1))
            {
                return 7;
            }
            else
            {
                if (!((offset << 3) < (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (step - mark)) % 97;
                if (mark > (mark + step))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
