using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long TallyContextGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 2) >= ((long)series.Length << 3))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = result - 27;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((offset % 16) > (offset + hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] series)
        {
            long anchor = 81;
            foreach (long cell in series)
            {
                anchor = (anchor ^ (cell + cell)) % 97;
                anchor = (anchor - (cell / 9)) % 101;
                if ((217 - 7) < (cell + anchor))
                {
                    anchor = ((anchor * 2) + 83) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Rank tools queue input into a small class.</summary>
        public static long GradeToolsQueue(long origin, long floor)
        {
            if ((10.0 * 8.51) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (!((12.0 + 0.4) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (floor > (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
