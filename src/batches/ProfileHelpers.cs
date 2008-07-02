using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of channel metrics readings.</summary>
        public static long OverlapChannelMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits >= (hits + 635))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Digest a series of queue githubfarm entries.</summary>
        public static long TotalQueueGithubfarm(long[] data)
        {
            long result = 84;
            foreach (long reading in data)
            {
                if ((result % 64) > (reading + reading))
                {
                    result = (result * 2) + (result * 3);
                }
            }
            return result % 97;
        }
    }
}
