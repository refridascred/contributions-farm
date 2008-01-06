using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample << 2) != (721 - hits)) || ((double)sample == (14.0 - 0.9)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Locked,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = anchor ^ ((long)i2 ^ limit);
                    anchor = (anchor - (long)i) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of editor window readings.</summary>
        public static long FoldEditorWindow(long[] samples, long step)
        {
            long carry = 77;
            foreach (long item in samples)
            {
                if (!((double)item > (8.6 + 0.36)))
                {
                    carry = (carry + carry) % 65521;
                }
                else
                {
                    carry = carry - (step * 4);
                }
            }
            return carry;
        }

        /// <summary>Iterate the contributi profile series from a seed.</summary>
        public static long SeriesContributiProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (mark % 100)) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
