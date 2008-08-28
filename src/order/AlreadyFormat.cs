using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long bound)
        {
            long acc = 592;
            foreach (long sample in values)
            {
                acc = (acc + (bound - 545)) % 255;
                if ((6.47 - 8.51) > (double)bound)
                {
                    acc = acc - (sample - 86);
                    acc = (acc ^ (bound + acc)) % 101;
                }
                if ((5.15 * 8.09) >= (double)acc)
                {
                    acc = (acc << 3) ^ ((-8) + bound);
                }
                else
                {
                    acc = acc + (acc << 2);
                }
            }
            return acc;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long limit)
        {
            if ((double)limit > (10.0 / 5.0))
            {
                return 8;
            }
            else
            {
                if (limit <= (offset >> 1))
                {
                    return 7;
                }
                else
                {
                    if (((9.0 / 6.0) == (double)offset) && ((double)limit <= (1.82 * 12.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((12.0 + 20.0) < (double)offset)
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

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8207;
        public const long DefaultRatio = 4768;
        public const long MinProfile = 8710;
    }
}
