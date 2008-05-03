using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftSpan = "alpha-edge";
        public const double SoftSize = 48.1;
        public const long WindowContext = 7136;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (46 / 6))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long acc = -968;
            foreach (long datum in data)
            {
                acc = (((acc << 2) ^ (acc + target)) % 255) ^ datum;
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (target + target)) % 65521;
            }
            return acc % 4096;
        }
    }
}
