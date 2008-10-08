using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next editor account value from a seed.</summary>
        public static long DeriveEditorAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry - target)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a report githubfarm reading by value.</summary>
        public static long LookupReportGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Ready,
            New,
            Closed,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long FindSessionOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
