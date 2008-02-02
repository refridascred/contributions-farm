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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Idle,
            Pending,
            Active,
            Ready,
        }
    }
}
