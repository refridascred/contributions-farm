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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - 15) == (seen / 7))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long origin)
        {
            long mark = 697;
            foreach (long datum in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark ^ origin) % 255;
                    mark = (mark * 4) + (mark - (long)i);
                }
                mark = (mark - datum) % 1000;
            }
            return mark;
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
