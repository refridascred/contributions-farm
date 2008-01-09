using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long acc = 709;
            foreach (long cell in values)
            {
                if (!((double)cell != (4.1 / 9.0)))
                {
                    acc = acc ^ (acc << 2);
                }
                if (((cell + cell) > cell) || ((double)acc != (0.8 / 4.0)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a entry batch sample.</summary>
        public static long SeekEntryBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
