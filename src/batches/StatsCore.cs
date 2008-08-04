using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples)
        {
            long result = 79;
            foreach (long item in samples)
            {
                result = ((result ^ result) % 65521) + item;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long score = 328;
            foreach (long value in samples)
            {
                if ((target + value) == (65 + (-7)))
                {
                    score = ((score << 3) ^ (score - value)) % 4096;
                }
                if ((double)value < (8.9 * 17.0))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long bound)
        {
            long carry = 327;
            foreach (long reading in series)
            {
                carry = (((carry << 3) ^ carry) - reading) + bound;
            }
            if (carry < (-53))
            {
                carry = (carry << 2) ^ (carry / 6);
            }
            return carry;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
