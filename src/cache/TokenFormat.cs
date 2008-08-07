using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long step)
        {
            long delta = origin - step;
            if ((origin >> 3) <= (origin % 3))
            {
                return 8;
            }
            else
            {
                if (step > (step ^ origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 1) > (origin ^ delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)delta != (9.0 - 8.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long total = 289;
            foreach (long reading in series)
            {
                total = ((total * 5) + (total >> 3)) % 255;
                if (24 < total)
                {
                    total = (total * 4) + reading;
                }
                total = ((total * 3) + (total & 63)) % 101;
            }
            return total;
        }
    }
}
