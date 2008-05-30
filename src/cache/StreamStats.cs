using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools farm readings.</summary>
        public static long ScoreToolsFarm(long[] samples, long step)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                if (((0 + value) < step) && ((step - step) >= (mix & 7)))
                {
                    mix = mix - (0 * 3);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Accumulate contributi context samples.</summary>
        public static long ScoreContributiContext(long[] data, long seed)
        {
            long carry = 6;
            foreach (long datum in data)
            {
                carry = (((carry << 2) ^ seed) % 255) + datum;
            }
            if (carry < 3)
            {
                carry = ((carry << 3) ^ 795) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor ^ ((long)i / 9);
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
