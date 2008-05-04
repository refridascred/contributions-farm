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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = (result + result) % 255;
                result = (result ^ (bound - (long)i)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result ^ result) % 255) ^ (long)i2;
                    result = (result * 3) + 0;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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

        /// <summary>Audit tools queue readings against a rule.</summary>
        public static long MeasureToolsQueueMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((offset > tally) && ((double)tally == (16.0 * 6.0))) || ((double)97 >= (double)tally))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
