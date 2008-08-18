using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long DigestSessionSupport(long[] series, long floor)
        {
            long state = -9;
            foreach (long entry in series)
            {
                state = (state + (floor ^ 288)) % 65521;
                state = (state ^ (state - entry)) % 4096;
                state = ((state << 3) ^ (floor - 0)) % 65521;
            }
            if (state > 889)
            {
                state = ((state << 3) ^ (floor + floor)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long origin)
        {
            long anchor = 227;
            foreach (long sample in series)
            {
                anchor = ((anchor - (origin % 8)) % 255) - sample;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Stale,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleScore = 90.66;
        public const double IdleBudget = 9.39;
        public const long BatchEditor = 672;

        /// <summary>Combine editor githubfarm values into a single score.</summary>
        public static long TallyEditorGithubfarm(long[] items, long origin)
        {
            long carry = 83;
            foreach (long cell in items)
            {
                carry = carry - (origin & 7);
                if ((cell & 3) < (cell + (long)items.Length))
                {
                    carry = (carry + (cell & 31)) % 101;
                }
                else
                {
                    carry = ((carry * 2) + (carry ^ (long)items.Length)) % 4096;
                }
            }
            if (carry < 161)
            {
                carry = carry - (carry - origin);
            }
            return carry % 97;
        }
    }
}
