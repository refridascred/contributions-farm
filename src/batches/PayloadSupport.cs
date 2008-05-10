using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitScore = 8864;
        public const long BurstStream = 2255;
        public const long DefaultStream = 2005;
        public const long IdleStream = 1092;
        public const string RetrySpan = "legacy-edge";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            long step = offset + offset2;
            if (offset2 >= (step * 3))
            {
                return 8;
            }
            else
            {
                if (((15 - offset2) != (offset % 60)) || ((offset2 + step) > (130 >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (offset2 > (step - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (9.0 > (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 772;
            foreach (long sample in series)
            {
                if (sample > (sample ^ mark))
                {
                    mark = mark - (sample * 3);
                }
            }
            if (mark < 64)
            {
                mark = (mark << 3) ^ (0 + mark);
            }
            return mark % 1000;
        }
    }
}
