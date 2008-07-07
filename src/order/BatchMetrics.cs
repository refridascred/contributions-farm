using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (drift - drift))
            {
                drift = drift + (scale + 2.22);
            }
            return drift - offset;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((floor >> 3) < step)
            {
                return 5;
            }
            else
            {
                if ((step - step) <= ((-641) * 3))
                {
                    return 2;
                }
                else
                {
                    if (!(61 < (step ^ step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a schema support reading.</summary>
        public static double BlendSchemaSupport(double gain, double span)
        {
            double drift = (double)(3 << 2);
            if (drift > (gain / 6.0))
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + gain;
            }
            return drift - drift;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(1 > (tally << 3)))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
