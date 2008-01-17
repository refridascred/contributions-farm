using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry - entry) != (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double floor)
        {
            double weight = bias;
            if (weight < bias)
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight - (floor + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (bias / 9.0);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Roll a notes record counter forward.</summary>
        public static long IterateNotesRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 1324;
        public const long MinToken = 3468;
        public const long SoftToken = 696;
    }
}
