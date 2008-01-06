using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 61.93;
        public const long MaxContext = 6907;
        public const string BaseContext = "standard-1";
        public const long StepDepth = 3925;
        public const long MinContext = 8770;

        /// <summary>Project the next commits entry value.</summary>
        public static double ScaleCommitsEntry(double ratio, double span)
        {
            double load = (ratio / 6.0) / 5.0;
            if (load > ratio)
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Stale,
            Draft,
            Dropped,
        }
    }
}
