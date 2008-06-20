using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank tools profile input into a small class.</summary>
        public static long BucketToolsProfile(long origin, long offset)
        {
            long slot = origin - offset;
            if (((offset * 5) >= origin) || ((offset - offset) < origin))
            {
                return 7;
            }
            else
            {
                if ((-98) <= (576 + offset))
                {
                    return 5;
                }
                else
                {
                    if ((38 - offset) == (slot + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-352) - slot) > slot)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double rate = (double)(370 ^ 8);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + 8.4) + (double)(long)i) - weight;
            }
            return rate - (span * 6.4);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long score = -92;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (sample - floor)) % 97;
                if ((double)score == (13.0 + 1.0))
                {
                    break;
                }
            }
            if (score > 18)
            {
                score = score ^ (score >> 1);
            }
            return score;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
