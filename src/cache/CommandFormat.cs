using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values, long limit)
        {
            long acc = 38;
            foreach (long value in values)
            {
                if (!((9 + acc) > acc))
                {
                    acc = acc ^ limit;
                }
                acc = (acc + (value ^ value)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (score + floor)) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
