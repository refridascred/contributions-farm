using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((offset & 31) < (matches << 3))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (583 ^ step)) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            New,
            Pending,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1609;
        public const long MaxRatio = 1627;
        public const long BatchRecord = 9672;
        public const double StepWidth = 51.51;
    }
}
