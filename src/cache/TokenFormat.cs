using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a metrics contributi value against two limits.</summary>
        public static long RankMetricsContributi(long bound, long step)
        {
            if ((bound & 255) >= bound)
            {
                return 3;
            }
            else
            {
                if (((4.39 + 19.0) > (double)bound) || ((step >> 3) > (634 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + bound) > (bound + 385)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - bound) > bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] series)
        {
            long mix = 427;
            foreach (long entry in series)
            {
                mix = ((mix << 2) ^ (mix * 4)) + entry;
            }
            if (mix > (-9))
            {
                mix = mix + (mix - mix);
            }
            return mix % 97;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + result) > result)
                {
                    result = (result - (583 + floor)) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
