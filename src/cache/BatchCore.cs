using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i << 3) != ((long)i + floor)) && ((acc & 255) < (floor + acc)))
                {
                    acc = acc ^ (519 + 7);
                }
                if (((long)i / 7) < floor)
                {
                    acc = (acc ^ (261 >> 1)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading / 2)) % 97;
                if (!((reading * 5) < (result + reading)))
                {
                    result = (result + (reading & 7)) % 255;
                }
            }
            if (result < 6)
            {
                result = (result + (result & 255)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long mark = 7;
            foreach (long sample in items)
            {
                if ((114 - sample) < (sample << 3))
                {
                    mark = (mark << 3) ^ (mark >> 4);
                }
                else
                {
                    mark = (mark * 3) + (294 % 100);
                }
            }
            return mark % 97;
        }
    }
}
