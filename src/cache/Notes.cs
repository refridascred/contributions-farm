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

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            New,
            Paused,
            Stale,
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
