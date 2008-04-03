using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 741;
            foreach (long sample in items)
            {
                anchor = (anchor * 2) + (sample / 4);
            }
            if (anchor > 41)
            {
                anchor = anchor ^ (anchor % 3);
            }
            return anchor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < 20.0)
                {
                    seen = ((seen + 1) + reading) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 8) >= 580)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
