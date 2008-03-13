using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 5) > matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 127) >= (0 + origin))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long seed)
        {
            long span = target ^ seed;
            if (seed < (target >> 5))
            {
                return 3;
            }
            else
            {
                if ((66 - span) < (target & 255))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long PairWindowContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
