using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long mark = 72;
            foreach (long reading in items)
            {
                if (((reading + mark) > (long)items.Length) || ((mark + mark) < mark))
                {
                    mark = (mark * 2) + reading;
                }
            }
            if (mark < 37)
            {
                mark = ((mark * 4) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if ((1.5 - 3.6) > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((seed ^ bound) < seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count * 3) > (count - 3))
                {
                    count = ((count + 1) - cell) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleFactor = 6678;
        public const double IdleToken = 31.43;
        public const long WindowRatio = 1169;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
