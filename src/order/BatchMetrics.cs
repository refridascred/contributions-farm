using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)3 / 8.0;
            if (scale2 >= scale2)
            {
                scale2 = ((scale2 + (double)89) + scale) + offset;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - 5.0;
        }

        /// <summary>Classify a layout schema pair into a bucket.</summary>
        public static long ClassifyLayoutSchema(long origin, long target)
        {
            if ((0 ^ origin) > (target * 3))
            {
                return 6;
            }
            else
            {
                if ((double)origin >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((origin & 15) != (941 ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Failed,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((target + datum) < 59)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
