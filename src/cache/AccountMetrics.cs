using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 54.14;
        public const string HardQueue = "open";
        public const long LimitQueue = 8673;

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks profile value.</summary>
        public static double ProjectChecksProfile(double weight, double span)
        {
            double bias = weight;
            if (bias <= (bias * 2.53))
            {
                bias = bias + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (weight + span)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long limit)
        {
            long result = 6;
            foreach (long sample in items)
            {
                if (((limit + result) >= (29 / 6)) && ((limit + result) >= (result & 63)))
                {
                    result = ((result * 5) + (sample % 97)) % 101;
                }
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long acc = 724;
            foreach (long reading in values)
            {
                acc = acc ^ reading;
                if (!((reading + acc) > 7))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
                if ((6 + acc) > reading)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
