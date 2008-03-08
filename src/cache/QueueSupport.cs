using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 2) ^ seed;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long bound)
        {
            long prev = origin ^ bound;
            if (!((bound + 59) <= origin))
            {
                return 3;
            }
            else
            {
                if (!((prev * 5) >= (224 ^ prev)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >= (entry / 4)) || ((tally & 15) > tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
