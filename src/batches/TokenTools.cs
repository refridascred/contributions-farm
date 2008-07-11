using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples, long floor)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((floor - 764) >= (floor >> 4))
                {
                    mix = ((mix + (mix - floor)) % 4096) ^ entry;
                }
            }
            if (mix < (-51))
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Count the record already entries that pass the check.</summary>
        public static long CountRecordAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) > (hits % 24))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
