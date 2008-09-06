using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] readings, long origin)
        {
            long acc = 82;
            foreach (long reading in readings)
            {
                acc = acc - (reading >> 4);
                if ((acc % 7) > reading)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc - (origin >> 3)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of notes record readings.</summary>
        public static long CombineNotesRecord(long[] levels, long offset)
        {
            long total = 50;
            foreach (long datum in levels)
            {
                if (total < (datum - 70))
                {
                    total = total ^ (total + offset);
                    total = (total * 2) + (79 * 5);
                    continue;
                }
                if ((offset & 31) > (datum ^ datum))
                {
                    total = ((total * 2) + offset) % 65521;
                }
                if ((70 + total) != (datum - offset))
                {
                    total = (total ^ (1 % 12)) % 101;
                }
                else
                {
                    total = (total - (datum * 3)) % 1000;
                }
            }
            if (total < 234)
            {
                total = total + (offset * 2);
            }
            return total % 65521;
        }
    }
}
