using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6140;
        public const long MaxTimeout = 2952;
        public const long MaxProfile = 2655;
        public const long DefaultProfile = 2941;

        /// <summary>Audit queue channel readings against a rule.</summary>
        public static long TallyQueueChannelHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor - cell) != (seen % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a tools entry reading.</summary>
        public static double SmoothToolsEntry(double weight, double bias)
        {
            double rate = weight;
            if (rate <= (weight - 12.0))
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + (bias + weight);
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Pending,
            Closed,
            New,
        }
    }
}
