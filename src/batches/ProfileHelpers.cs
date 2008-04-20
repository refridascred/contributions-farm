using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count editor notes pairs that satisfy a relation.</summary>
        public static long CompareEditorNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)matches == (3.04 + 19.0)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Combine entry contributi values into a single score.</summary>
        public static long FoldEntryContributi(long[] series)
        {
            long mark = -4;
            foreach (long entry in series)
            {
                if ((mark & 63) == (mark * 3))
                {
                    mark = (mark ^ (71 + entry)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ 19) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
