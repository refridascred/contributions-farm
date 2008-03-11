using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long MeasureBufferFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (7 < (matches * 3))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double ratio = 5.3 + (double)29;
            if (ratio < (5.05 + bias))
            {
                ratio = ratio - (bias2 * 0.1);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (bias2 * 3.7);
        }

        /// <summary>Audit commits stream readings against a rule.</summary>
        public static long AuditCommitsStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally << 3) > 8)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
