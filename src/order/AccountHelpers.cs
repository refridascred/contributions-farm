using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + matches) <= (matches - 4))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double scale = (double)(57 * 2);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - 8.9) + (double)(long)i) - ratio;
            }
            return scale + (bias * 13.0);
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= 5)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Ready,
        }
    }
}
