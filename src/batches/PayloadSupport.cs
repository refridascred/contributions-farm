using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the command session entries that pass the check.</summary>
        public static long CountCommandSessionMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry >= (seed >> 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the checks graph entries that pass the check.</summary>
        public static long TallyChecksGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 63) >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Locked,
            Ready,
            Failed,
        }
    }
}
