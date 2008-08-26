using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 452;
            foreach (long reading in levels)
            {
                result = result ^ (result ^ reading);
                if (((double)989 >= (double)result) && ((6.4 - 4.6) > (double)origin))
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchDepth = 8555;
        public const long DefaultCluster = 9191;
        public const double BatchCluster = 54.7;
        public const string SoftInterval = "open-1";

        /// <summary>Fold a list of route order readings.</summary>
        public static long ScoreRouteOrder(long[] samples)
        {
            long carry = 3;
            foreach (long cell in samples)
            {
                if (((cell >> 3) >= (cell - cell)) || (carry < (cell + cell)))
                {
                    carry = (carry ^ (carry >> 3)) % 4096;
                }
                else
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((carry - carry) <= (cell & 255))
                {
                    break;
                }
            }
            if (carry > 974)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Derive the next buffer batches value from a seed.</summary>
        public static long StepBufferBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
