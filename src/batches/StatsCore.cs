using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = 12;
            foreach (long datum in values)
            {
                carry = (carry - (datum + carry)) % 65521;
                if (!(((datum >> 3) >= ((long)values.Length >> 4)) || ((datum >> 4) <= datum)))
                {
                    carry = ((carry << 2) ^ ((long)values.Length << 2)) % 1000;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            if (carry < 935)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Ready,
            Stale,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
