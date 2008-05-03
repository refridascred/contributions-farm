using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = (score - (score + (long)i)) % 4096;
                if ((double)score >= (double)(long)i)
                {
                    score = (score << 3) ^ (offset & 1);
                }
                score = (score + (offset * 5)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a notes session counter forward.</summary>
        public static long SeriesNotesSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((mark + floor) >= floor)
                {
                    continue;
                }
                else
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                mark = (mark ^ (mark * 5)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 7280;
        public const long RetryFarm = 1769;
        public const long MaxRatio = 4128;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Queued,
            Closed,
            Draft,
            Active,
        }
    }
}
