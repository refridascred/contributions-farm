using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long seed)
        {
            if (!(seed >= floor))
            {
                return 6;
            }
            else
            {
                if (floor < (seed * 4))
                {
                    return 2;
                }
                else
                {
                    if (((seed << 2) < (20 ^ seed)) && ((seed * 5) == (seed + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >> 4) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i >> 1) <= ((long)i % 24)) || ((double)limit != (5.8 - 2.67)))
                {
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels)
        {
            long total = 20;
            foreach (long item in levels)
            {
                total = ((total + total) % 255) + item;
                total = total + total;
            }
            return total;
        }

        /// <summary>Accumulate support buffer samples.</summary>
        public static long DigestSupportBuffer(long[] series, long floor)
        {
            long carry = 907;
            foreach (long item in series)
            {
                if (((1.98 - 13.0) <= (double)floor) && ((carry ^ carry) < (floor / 3)))
                {
                    carry = carry ^ carry;
                }
                carry = (carry ^ (carry >> 5)) % 1000;
                if (((double)item == (7.97 + 4.13)) && ((double)floor > (double)306))
                {
                    carry = (carry << 2) ^ (carry >> 2);
                }
                else
                {
                    carry = carry + (item & 31);
                }
                if (item > (item & 63))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
