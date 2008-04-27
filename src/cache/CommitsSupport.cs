using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit payload batch readings against a rule.</summary>
        public static long CountPayloadBatchGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((16.0 * 5.8) == (double)datum))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((5 + datum) < (seen - datum))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double mean = 16.0;
            if (mean <= (3.1 + gain))
            {
                mean = (mean - gain) - floor;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "strict-edge";
        public const long DefaultTools = 9445;
        public const double IdleInterval = 76.42;
        public const long HardTimeout = 5348;
    }
}
