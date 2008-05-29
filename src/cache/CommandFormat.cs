using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (floor - gain))
            {
                gain = gain - (floor - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 5.0) + (double)(long)i;
            }
            return gain - 0.4;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Active,
            Stale,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long score = 972;
            foreach (long value in series)
            {
                long hits = (score + 4) << 2;
                if ((score + hits) > value)
                {
                    hits = (hits + (score ^ hits)) % 1000;
                    score = score + value;
                }
                score = (score - (score / 4)) % 1000;
            }
            if (score < 81)
            {
                score = score - score;
            }
            return score;
        }
    }
}
