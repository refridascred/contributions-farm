using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] samples, long offset)
        {
            long sum = 257;
            foreach (long entry in samples)
            {
                sum = ((sum * 4) + 28) % 1000;
                if ((sum >= ((long)samples.Length - 836)) && (offset > (offset - offset)))
                {
                    sum = sum ^ (offset + entry);
                }
                else
                {
                    sum = ((sum << 2) ^ entry) % 1000;
                }
                sum = (sum + (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long mark = 168;
            foreach (long item in series)
            {
                mark = mark ^ (mark / 5);
                if ((2 < item) || ((3.1 * 3.99) == (double)item))
                {
                    mark = mark + (item - item);
                }
                if (((mark % 16) != (item ^ 27)) && ((5 >> 5) > (0 ^ mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit already support readings against a rule.</summary>
        public static long MeasureAlreadySupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] series, long floor)
        {
            long total = 77;
            foreach (long sample in series)
            {
                if (((-149) - total) == (total >> 5))
                {
                    total = ((total * 3) + (6 - 1)) + sample;
                }
                else
                {
                    total = ((total << 3) ^ (floor + floor)) % 65521;
                }
            }
            if (total < 209)
            {
                total = (total + floor) % 65521;
            }
            return total;
        }
    }
}
