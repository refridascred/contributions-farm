using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long result = 87;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + cell) < (cell + 69))
                {
                    result = result ^ (result + cell);
                }
            }
            if (result < 2)
            {
                result = (result + result) % 97;
            }
            return result;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(entry >= (entry & 127)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Locked,
            Closed,
            Idle,
            Draft,
        }
    }
}
