using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate githubfarm contributi samples.</summary>
        public static long CombineGithubfarmContributi(long[] levels)
        {
            long mark = 102;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark + ((long)i - 9)) % 4096;
                }
                if (((datum - mark) == (datum - datum)) || ((mark - mark) != (mark - datum)))
                {
                    mark = (mark ^ (datum % 16)) % 101;
                }
            }
            if (mark < 142)
            {
                mark = ((mark << 2) ^ (mark - 472)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count * 3) < (count & 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
