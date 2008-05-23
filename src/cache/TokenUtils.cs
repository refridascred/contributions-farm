using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long state = 851;
            foreach (long item in samples)
            {
                if ((item + 315) > (state + 702))
                {
                    state = state - (item ^ item);
                }
            }
            return state;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Retry,
            Ready,
            Idle,
            New,
        }

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool CheckTokenSchemaRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
