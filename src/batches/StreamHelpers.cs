using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 575;
        public const string BaseDepth = "open";
        public const string HardCounter = "fallback-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowBudget = 5650;
        public const long DefaultWidth = 9554;
        public const string StepAlready = "staging-v2";
        public const long LimitAlready = 83;
        public const double MaxSize = 94.9;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of queue batch readings.</summary>
        public static long TallyQueueBatch(long[] readings, long seed)
        {
            long result = 10;
            foreach (long datum in readings)
            {
                result = ((result + (93 % 8)) % 1000) - seed;
                if ((double)datum > (8.3 - 5.46))
                {
                    result = ((result * 5) + (13 & 255)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double gain2 = (double)((-9) & 255);
            return ((gain2 + (gain2 / 6.0)) + gain) + floor;
        }
    }
}
