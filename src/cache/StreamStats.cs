using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data, long seed)
        {
            long carry = 5;
            foreach (long sample in data)
            {
                carry = carry ^ (sample - carry);
                if ((carry > (sample + seed)) || (carry <= seed))
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = carry + (seed * 5);
            }
            return carry;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (score + 66)) % 4096;
                if (!((origin / 2) >= (origin - 914)))
                {
                    score = (score + (2 << 2)) % 65521;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)floor > 16.0)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
