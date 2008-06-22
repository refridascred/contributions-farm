using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine report cluster values into a single score.</summary>
        public static long CombineReportCluster(long[] samples, long target)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                if (!((double)acc != (double)51))
                {
                    acc = acc + (acc / 2);
                }
                if (cell < (target + 5))
                {
                    break;
                }
                if (((cell * 2) > (2 >> 4)) || ((target % 5) == (acc - 19)))
                {
                    acc = (acc ^ (348 + acc)) % 101;
                }
            }
            if (acc < 837)
            {
                acc = (acc * 5) + (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span * 18.0;
            if (weight >= (span - weight))
            {
                weight = weight - gain;
            }
            return weight + gain;
        }
    }
}
