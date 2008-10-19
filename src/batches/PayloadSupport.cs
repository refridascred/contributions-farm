using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Stale,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset != (double)(long)i)
                {
                    mix = mix - (mix >> 4);
                    break;
                }
                mix = ((mix << 3) ^ offset) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long floor)
        {
            if (((bound + bound) != (bound + (-708))) || ((floor >> 4) >= (floor + bound)))
            {
                return 0;
            }
            else
            {
                if (!((floor - bound) > (bound << 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
