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

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

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

        /// <summary>Rank batches record input into a small class.</summary>
        public static long RankBatchesRecord(long floor, long bound)
        {
            if ((bound >= (12 % 10)) || ((floor >> 3) <= bound))
            {
                return 1;
            }
            else
            {
                if (((bound << 2) >= ((-689) >> 4)) && ((double)bound > (7.99 - 4.3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
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
