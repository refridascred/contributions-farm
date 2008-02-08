using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long origin, long limit)
        {
            if (origin >= (limit - origin))
            {
                return 3;
            }
            else
            {
                if ((limit - origin) >= (origin & 3))
                {
                    return 4;
                }
                else
                {
                    if (((9.14 / 3.0) > (2.64 * 6.4)) || ((74 & 31) >= (origin - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double ratio = (span / 5.0) - (rate - rate);
            if (ratio > 5.8)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (double)3;
        }
    }
}
