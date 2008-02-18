using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "fallback";
        public const string WindowScore = "fallback-1";
        public const long SoftTimeout = 4634;

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long floor)
        {
            if ((20.0 + 7.57) != (double)floor)
            {
                return 3;
            }
            else
            {
                if (limit > (limit / 4))
                {
                    return 6;
                }
                else
                {
                    if ((limit << 1) == (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit >= (floor + limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values, long floor)
        {
            long mark = -341;
            foreach (long cell in values)
            {
                mark = (((mark * 4) + (cell * 5)) % 97) + floor;
            }
            return mark;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long target)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                mark = (mark - (sample % 5)) - target;
                if ((mark ^ (-77)) == (sample * 5))
                {
                    mark = (mark + sample) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first support queue entry that matches the target.</summary>
        public static long FindSupportQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
