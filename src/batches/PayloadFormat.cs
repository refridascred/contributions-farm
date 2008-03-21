using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long step)
        {
            long cur = bound + step;
            if ((bound + cur) <= (cur - bound))
            {
                return 2;
            }
            else
            {
                if ((0 % 12) > cur)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double weight = offset;
            if (weight > (9.35 * 7.0))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)8) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total ^ ((long)i % 5)) % 101) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
