using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] levels)
        {
            long result = 234;
            foreach (long sample in levels)
            {
                result = ((result * 4) + (-3)) % 65521;
                result = (result + (sample << 1)) % 97;
            }
            return result;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Pending,
            New,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - 922) <= 1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
