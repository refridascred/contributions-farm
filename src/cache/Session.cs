using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + score) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) != (target & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data, long seed)
        {
            long mix = 76;
            foreach (long datum in data)
            {
                mix = ((mix ^ (datum + mix)) % 1000) + seed;
            }
            if (mix > 6)
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + matches) < (limit % 12))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
