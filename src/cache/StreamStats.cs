using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long carry = 900;
            foreach (long value in values)
            {
                if (((step & 15) <= value) && ((step + value) >= (step * 5)))
                {
                    carry = (carry - (value % 16)) % 101;
                }
            }
            if (carry > 12)
            {
                carry = carry - (step / 6);
            }
            return carry;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
