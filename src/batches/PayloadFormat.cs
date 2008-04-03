using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 5045;
        public const double HardPayload = 97.03;
        public const string LimitLevel = "local";

        /// <summary>Rank context cache input into a small class.</summary>
        public static long GradeContextCache(long origin, long offset)
        {
            if (((offset % 24) > (origin / 5)) && ((double)offset <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin + offset) <= (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long mix = 580;
            foreach (long datum in readings)
            {
                if (((long)readings.Length - datum) > datum)
                {
                    mix = (mix - (mix + mix)) - limit;
                }
                else
                {
                    mix = ((mix * 3) + (datum / 7)) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (494 * 5)) % 65521;
            }
            return mix;
        }
    }
}
