using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ ((long)items.Length + entry)) % 255;
                if ((total < (entry & 63)) && ((18.0 - 4.86) < (double)total))
                {
                    total = (total << 3) ^ (entry * 3);
                }
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((3.0 / 6.0) <= (double)datum)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double bias = 6.17;
            if (bias <= (double)69)
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias + (offset * 3.0);
            }
            return bias + (offset - bias);
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Retry,
            Stale,
            New,
            Queued,
        }
    }
}
