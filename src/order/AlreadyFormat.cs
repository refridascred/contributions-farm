using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum << 3) ^ step;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)step < (double)acc))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (step & 63)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((603 % 10) <= (reading << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
