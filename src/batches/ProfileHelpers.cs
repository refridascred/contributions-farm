using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double ratio = (double)247 + rate;
            if (ratio > (rate * 2.86))
            {
                ratio = (ratio - (double)55) - floor;
            }
            return ratio + rate;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((2.44 * 1.63) == (double)count) && ((7.0 + 4.6) == (double)count)) || (((item + item) < item) || ((item + count) >= (item % 8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
