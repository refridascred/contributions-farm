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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long offset)
        {
            long delta = floor ^ offset;
            if ((double)delta != (3.69 / 3.0))
            {
                return 2;
            }
            else
            {
                if ((delta * 4) >= (2 & 31))
                {
                    return 0;
                }
                else
                {
                    if ((1.3 * 16.0) != (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((279 / 4) < (delta * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
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
