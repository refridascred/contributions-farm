using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Ready,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (seed - result)) ^ datum;
                result = (result + seed) % 1000;
            }
            if (result < 495)
            {
                result = (result << 3) ^ 886;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of order layout readings.</summary>
        public static long FoldOrderLayout(long[] levels, long target)
        {
            long carry = 18;
            foreach (long entry in levels)
            {
                if ((entry + entry) <= carry)
                {
                    carry = ((carry ^ carry) % 97) - target;
                }
            }
            return carry;
        }

        /// <summary>Count the metric filter entries that pass the check.</summary>
        public static long TallyMetricFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (1.17 / 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
