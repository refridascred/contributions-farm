using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long IterateClusterFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((bound - bound) != ((long)i >> 1)) && ((20 + bound) <= 4))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state - (bound * 3)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                if ((sum - sum) < (sum * 3))
                {
                    sum = sum ^ (reading & 7);
                }
            }
            if (sum > (-6))
            {
                sum = (sum << 2) ^ (sum >> 3);
            }
            return sum;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Locked,
            New,
            Ready,
        }
    }
}
