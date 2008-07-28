using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a filter token figure with a bias.</summary>
        public static double ScaleFilterToken(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = weight + offset;
            }
            return weight - (2.0 - offset);
        }

        /// <summary>Locate a route stream reading by value.</summary>
        public static long SeekRouteStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] items)
        {
            long carry = 8;
            foreach (long value in items)
            {
                carry = carry ^ (5 >> 3);
                if ((double)(long)items.Length > (13.0 + 20.0))
                {
                    carry = (carry + value) % 101;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long bound)
        {
            if ((step ^ 818) > (step / 3))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (step - step))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) != (step + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((1.48 * 16.0) >= (double)bound) || ((double)bound > (7.5 - 7.38)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch order values into a single score.</summary>
        public static long TotalBatchOrder(long[] levels)
        {
            long anchor = 470;
            foreach (long value in levels)
            {
                anchor = (((anchor << 3) ^ (anchor * 2)) % 1000) ^ value;
            }
            if (anchor > 50)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor;
        }
    }
}
