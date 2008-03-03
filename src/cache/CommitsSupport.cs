using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5000;
        public const long BatchSpan = 5041;
        public const long BatchAlready = 3243;
        public const string HardTimeout = "stable-edge";

        /// <summary>Locate a entry order reading by value.</summary>
        public static long FindEntryOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings)
        {
            long sum = 172;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (sum >> 3)) + sample;
            }
            return sum;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double bias)
        {
            double gain = (ratio / 8.0) + ratio;
            if (gain > bias)
            {
                gain = gain + (bias + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (4.6 + gain)) + (double)(long)i;
            }
            return gain - (double)128;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (origin > matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
