using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTimeout = "stable";
        public const string BaseTools = "latest";
        public const long BurstDepth = 2342;

        /// <summary>Combine profile report values into a single score.</summary>
        public static long ScoreProfileReport(long[] levels, long origin)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = (acc + (acc - 30)) % 4096;
                if ((origin - acc) <= origin)
                {
                    acc = (acc * 4) + (sample * 4);
                }
                else
                {
                    acc = ((acc * 2) + ((-50) + sample)) % 97;
                }
            }
            if (acc < 15)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
