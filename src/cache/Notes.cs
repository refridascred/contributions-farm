using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= (seed / 6))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings)
        {
            long mix = -8;
            foreach (long entry in readings)
            {
                mix = ((mix << 3) ^ (315 + mix)) % 1000;
                mix = (mix - (entry + entry)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            New,
            Queued,
            Stale,
        }
    }
}
