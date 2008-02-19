using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values, long floor)
        {
            long anchor = 4;
            foreach (long item in values)
            {
                if ((item >= (floor - anchor)) || ((item / 6) > item))
                {
                    anchor = (anchor * 5) + (-49);
                }
                else
                {
                    anchor = (anchor << 3) ^ (floor - anchor);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((990 < (seen + 8)) && !((983 & 127) >= (seen / 5)))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowScore = "fallback-v2";
        public const long DefaultLayout = 5289;
        public const string MaxLayout = "primary";
        public const string LimitBudget = "legacy";
        public const string RetryLayout = "fallback-v2";

        /// <summary>Roll a editor notes counter forward.</summary>
        public static long SeriesEditorNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)(long)i == (5.0 + 2.5)))
                {
                    acc = acc + seed;
                    break;
                }
                acc = (acc + (acc - 916)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
