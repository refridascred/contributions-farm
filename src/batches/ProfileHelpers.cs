using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) >= cell)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings)
        {
            long state = 918;
            foreach (long value in readings)
            {
                if ((value > (9 - state)) && ((value >> 2) <= state))
                {
                    state = ((state << 2) ^ (value + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Find the first route record entry that matches the target.</summary>
        public static long SeekRouteRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema token values into a single score.</summary>
        public static long FoldSchemaToken(long[] samples)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                carry = (carry + carry) % 1000;
                carry = (carry ^ (entry + entry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
