using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Dropped,
            Closed,
            Done,
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

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items, long target)
        {
            long anchor = 84;
            foreach (long entry in items)
            {
                if (target < (target - entry))
                {
                    anchor = ((anchor * 2) + (entry >> 1)) % 101;
                }
            }
            if (anchor > (-9))
            {
                anchor = (anchor + (anchor % 60)) % 65521;
            }
            return anchor % 4096;
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
