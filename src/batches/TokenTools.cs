using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 3) + (carry + (-643));
                carry = (carry + (floor - (long)i)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (538 <= (reading % 12))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long anchor = 94;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ seed) % 97) + datum;
            }
            if (anchor > 868)
            {
                anchor = (anchor + (anchor - anchor)) % 65521;
            }
            return anchor % 1000;
        }
    }
}
