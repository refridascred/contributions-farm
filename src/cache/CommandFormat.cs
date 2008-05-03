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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally - value) >= (tally + value)) || (value > (tally + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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
