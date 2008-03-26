using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample % 7) <= (count << 1)) || (count > (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit cluster checks readings against a rule.</summary>
        public static long MeasureClusterChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen << 2) > (33 * 2)) || ((4 - seen) == (reading << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Done,
            New,
            Pending,
        }
    }
}
