using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cluster support readings.</summary>
        public static long TotalClusterSupport(long[] samples)
        {
            long acc = 84;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (18 << 2)) + (long)i;
                }
                acc = (acc - datum) % 1000;
                acc = ((acc * 3) + (datum - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin * 4) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
