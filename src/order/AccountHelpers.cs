using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long limit)
        {
            if ((double)offset <= (9.1 * 4.2))
            {
                return 5;
            }
            else
            {
                if (((offset - offset) == (947 << 3)) || ((3.0 - 17.0) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 2) <= 506)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((637 & 15) <= (offset + 512))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long CombineChannelEditor(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                mix = (mix + 4) ^ value;
            }
            return mix;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long floor)
        {
            long next = step - floor;
            if (next >= (step & 15))
            {
                return 5;
            }
            else
            {
                if (!(step > floor))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 31)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
