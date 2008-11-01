using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long score = 5;
            foreach (long datum in data)
            {
                score = score - datum;
                if (datum < (datum & 31))
                {
                    score = ((score << 3) ^ datum) % 4096;
                }
                else
                {
                    score = (score ^ score) % 1000;
                }
            }
            if (score < 4)
            {
                score = ((score << 3) ^ (score / 3)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
