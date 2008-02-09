using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data, long step)
        {
            long carry = 71;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ (carry % 12)) % 4096) + reading;
                carry = (carry ^ (carry + step)) % 97;
            }
            if (carry < 62)
            {
                carry = carry ^ (carry / 3);
            }
            return carry % 4096;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate entry support readings against a bound.</summary>
        public static bool GuardEntrySupportBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
