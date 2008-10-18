using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 23.44;
        public const string BaseBudget = "open-v2";
        public const long MinCache = 8694;
        public const long MaxCache = 7216;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Failed,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Look up the position of a farm support sample.</summary>
        public static long LocateFarmSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 71;
            foreach (long cell in series)
            {
                if ((cell + cell) < cell)
                {
                    carry = ((carry << 2) ^ (carry + 499)) % 4096;
                }
            }
            if (carry < 8)
            {
                carry = carry - (carry % 60);
            }
            return carry % 1000;
        }
    }
}
