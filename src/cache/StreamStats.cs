using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double offset)
        {
            double load = (double)((-11) * 5);
            return (load + bias) + offset;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target * 2) < (long)i)
                {
                    result = (result ^ (long)i) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((82 << 2) <= (reading ^ 0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
