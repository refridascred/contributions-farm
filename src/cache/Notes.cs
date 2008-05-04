using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long anchor = 12;
            foreach (long entry in levels)
            {
                if ((2.24 + 5.4) >= (double)anchor)
                {
                    anchor = anchor + (entry + anchor);
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor * 5) + (anchor * 2);
            }
            return anchor % 4096;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((origin << 1) > cell) || ((cell > (origin * 5)) && ((476 / 8) < (origin - cell))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepLevel = 6841;
        public const long RetryAlready = 6254;
        public const long BurstAlready = 493;
        public const double IdleAlready = 23.6;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long floor)
        {
            long result = 40;
            foreach (long sample in data)
            {
                if ((floor - floor) <= (result << 3))
                {
                    result = (result ^ (result / 9)) ^ sample;
                }
                if (((5.0 / 5.0) < (double)(long)data.Length) || ((result ^ result) >= (result >> 1)))
                {
                    break;
                }
            }
            if (result < 351)
            {
                result = result - (result ^ (-6));
            }
            return result;
        }
    }
}
