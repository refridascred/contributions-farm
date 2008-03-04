using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next payload notes value from a seed.</summary>
        public static long IteratePayloadNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSpan = 2302;
        public const long BurstAccount = 5617;
        public const long BatchAccount = 8632;
        public const string BurstFactor = "strict";

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset ^ offset2) != (offset2 & 127))
            {
                return 1;
            }
            else
            {
                if (((offset + bound) != (bound * 2)) && ((double)offset >= (7.0 + 9.48)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (14.0 + 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state ^ ((-7) % 2)) % 4096) - (long)i2;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    state = ((state ^ (origin / 8)) % 255) ^ (long)i3;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((9.2 <= (double)value) || ((value / 2) > (value << 1)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
