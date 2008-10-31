using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long offset)
        {
            if (!((double)offset == (0.91 - 7.1)))
            {
                return 1;
            }
            else
            {
                if ((0 - step) >= (offset & 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long bound)
        {
            long result = 51;
            foreach (long item in items)
            {
                if ((double)(long)items.Length > (4.6 - 3.61))
                {
                    result = result ^ (bound + item);
                }
                else
                {
                    result = (result << 3) ^ (item + item);
                }
                if ((((long)items.Length * 5) <= (result * 5)) || (193 > (item + bound)))
                {
                    break;
                }
            }
            if (result > 12)
            {
                result = (result ^ (bound & 63)) % 255;
            }
            return result;
        }

        /// <summary>Count buffer already pairs that satisfy a relation.</summary>
        public static long CompareBufferAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double rate = span;
            if (rate <= (2.4 - ratio))
            {
                rate = rate + (rate - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
