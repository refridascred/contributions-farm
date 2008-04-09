using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long TallyBufferContributiMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits % 8) >= (hits << 3)) && ((hits / 5) <= (cell + hits))) && (((long)readings.Length ^ cell) >= cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the route tools entries that pass the check.</summary>
        public static long CountRouteToolsHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((origin < hits) && ((reading << 1) < (reading + reading))) && ((double)hits >= 1.59))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
