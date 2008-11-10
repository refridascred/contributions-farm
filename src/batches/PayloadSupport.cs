using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((floor >> 2) >= tally)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a route account counter forward.</summary>
        public static long IterateRouteAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 3) + (result & 255);
                if (((result / 9) == (long)i) && ((double)result <= (8.49 * 1.0)))
                {
                    result = (result - (result + floor)) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
