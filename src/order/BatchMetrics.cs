using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a counter batches figure with a bias.</summary>
        public static double BlendCounterBatches(double scale, double offset)
        {
            double bias = offset;
            if (bias < (double)59)
            {
                bias = bias + (scale - offset);
            }
            else
            {
                bias = bias + (scale - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)110) - (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(count < (cell >> 2)) && (limit > (count % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset + 930) < (offset2 >> 4))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 <= (8.33 * 5.6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate payload schema readings against a bound.</summary>
        public static bool GuardPayloadSchemaLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a token notes sample.</summary>
        public static long FindTokenNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
