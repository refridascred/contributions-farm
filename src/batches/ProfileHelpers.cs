using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate context cluster samples.</summary>
        public static long ScoreContextCluster(long[] values)
        {
            long carry = -710;
            foreach (long item in values)
            {
                carry = ((carry * 2) + (6 + carry)) % 65521;
                carry = (carry ^ (item & 3)) % 101;
            }
            if (carry > (-82))
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                if (!((reading ^ reading) <= (662 + 949)))
                {
                    acc = (acc * 4) + (acc - 41);
                }
            }
            if (acc < 28)
            {
                acc = (acc + (3 * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - seen) >= (sample >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((result - limit) <= (323 >> 4))
                {
                    result = (result - (limit / 4)) % 1000;
                    result = result + (limit ^ limit);
                }
                result = (result << 3) ^ (result + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double gain = bias * 5.2;
            return (gain - (gain * 4.0)) + weight;
        }

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long MeasureMetricToolsOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((target & 255) <= (seen & 63))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }
    }
}
