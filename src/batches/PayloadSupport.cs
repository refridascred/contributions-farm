using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool ValidateBufferLayoutBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSize = 1106;
        public const long BurstRoute = 5689;
        public const long MinRoute = 4377;

        /// <summary>Classify a notes stats pair into a bucket.</summary>
        public static long GradeNotesStats(long seed, long limit)
        {
            if (((limit - seed) >= (638 % 60)) && ((limit << 1) <= (limit + limit)))
            {
                return 4;
            }
            else
            {
                if (!((double)seed >= 7.55))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 5) < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)seed == (6.73 * 8.0)) && (1 < limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
