using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next notes tools value from a seed.</summary>
        public static long SeriesNotesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long TallyGraphStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + matches) > datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long acc = -746;
            foreach (long cell in readings)
            {
                acc = (acc << 2) ^ (seed / 5);
                if (592 >= cell)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Synced,
            New,
            Draft,
            Retry,
        }
    }
}
