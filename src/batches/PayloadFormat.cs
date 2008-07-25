using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool CheckLayoutStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long seed)
        {
            if (((double)7 != (double)offset) && ((double)offset == (6.91 + 7.0)))
            {
                return 7;
            }
            else
            {
                if ((6.5 - 2.16) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((-248) % 97) > (seed + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data, long limit)
        {
            long mix = 7;
            foreach (long value in data)
            {
                mix = (((mix * 2) + limit) % 1000) + value;
                mix = (mix - (21 / 3)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((5.13 + 6.0) == (double)floor))
                {
                    score = ((score * 2) + (floor / 3)) % 101;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
