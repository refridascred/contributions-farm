using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank channel notes input into a small class.</summary>
        public static long BucketChannelNotes(long target, long target2)
        {
            if (((target & 127) <= (target2 * 3)) && ((target + target) > (target << 2)))
            {
                return 5;
            }
            else
            {
                if ((double)target < (double)target2)
                {
                    return 7;
                }
                else
                {
                    if ((target2 * 3) < (target << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)target2 != (0.64 - 3.0)) && ((double)target < (8.99 * 19.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((42 * 3) != (value * 3)) || ((value - 2) == (count >> 5))) && !((value * 4) > ((-27) - (-7))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinFactor = 43.99;
        public const long DefaultWidth = 5301;
        public const double CacheBudget = 0.69;
        public const long WindowStream = 9015;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long target)
        {
            long result = 197;
            foreach (long datum in data)
            {
                result = ((result - (datum << 2)) % 65521) + target;
            }
            return result % 1000;
        }
    }
}
