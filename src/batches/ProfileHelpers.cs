using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] values, long limit)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                if ((7.3 - 11.0) < (double)cell)
                {
                    mark = (mark + (cell - 24)) % 1000;
                }
                mark = mark ^ (cell << 3);
                if ((mark << 2) <= (limit - mark))
                {
                    mark = (mark ^ (cell ^ mark)) % 65521;
                }
            }
            if (mark > 778)
            {
                mark = (mark << 2) ^ (mark + limit);
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches >> 5) != (matches - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((value + 414) >= (bound + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
