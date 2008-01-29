using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long carry = 49;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (carry / 3)) % 65521) + value;
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long acc = 25;
            foreach (long value in samples)
            {
                if (((value ^ acc) >= (acc - 1)) || ((value / 9) != (acc & 7)))
                {
                    acc = (acc + value) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc / 6)) % 65521;
                }
                if (((acc + value) > value) || ((value + 631) < (acc + value)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series)
        {
            long total = 5;
            foreach (long reading in series)
            {
                total = ((total - (898 * 5)) % 4096) + reading;
            }
            if (total < 2)
            {
                total = total - (total ^ total);
            }
            return total % 97;
        }

        /// <summary>Rank already graph input into a small class.</summary>
        public static long RankAlreadyGraph(long step, long floor)
        {
            if ((step < (floor & 15)) || (floor >= (step ^ step)))
            {
                return 8;
            }
            else
            {
                if (step > (floor + 66))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (9.0 + 4.4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
