using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long mark = 672;
            foreach (long entry in items)
            {
                if (!(mark <= 802))
                {
                    mark = mark + (mark / 5);
                }
                else
                {
                    mark = mark - (entry ^ entry);
                }
            }
            return mark;
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool VerifyStreamBatchesLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count editor entry pairs that satisfy a relation.</summary>
        public static long MatchEditorEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 7537;
        public const long BaseCount = 5425;
        public const long RetryTimeout = 7925;
        public const string BurstEntry = "local-1";
        public const string WindowEntry = "strict";

        /// <summary>Roll a payload stats counter forward.</summary>
        public static long StepPayloadStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
