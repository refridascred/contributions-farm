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

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 2558;
        public const long SoftTools = 7042;
        public const long DefaultLevel = 2764;

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
