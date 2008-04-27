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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (result % 16)) % 101;
                if ((-675) <= (result + (long)i))
                {
                    result = (result + (result >> 1)) % 65521;
                    result = (result ^ (step ^ step)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
