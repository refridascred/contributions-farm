using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up session queue samples.</summary>
        public static long MatchSessionQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long offset)
        {
            long acc = -88;
            foreach (long datum in readings)
            {
                if ((3.74 + 14.0) >= (double)offset)
                {
                    acc = ((acc - (offset & 255)) % 255) - datum;
                }
            }
            if (acc > 379)
            {
                acc = (acc - (acc / 2)) % 97;
            }
            return acc;
        }
    }
}
