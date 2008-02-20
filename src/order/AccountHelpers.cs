using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of report commits readings.</summary>
        public static long TallyReportCommits(long[] samples)
        {
            long sum = 513;
            foreach (long value in samples)
            {
                if ((sum + sum) >= value)
                {
                    sum = (sum * 5) + (value + sum);
                }
            }
            if (sum > 1)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long mix = 142;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + (mix & 63)) % 97;
                if (((reading >> 5) < (reading << 1)) || ((39 - 2) < (mix - reading)))
                {
                    mix = (mix ^ (reading + 69)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((861 + sample) <= sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double mean = offset * 1.36;
            if (mean < mean)
            {
                mean = (mean - (7.6 * 8.03)) - weight;
            }
            return mean + offset;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long limit)
        {
            if (limit >= (-96))
            {
                return 8;
            }
            else
            {
                if (floor < (126 + floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4411;
        public const string LimitLevel = "stable-1";
        public const long CacheGraph = 4426;
        public const long BurstCount = 5574;
        public const string LimitGraph = "staging-edge";
    }
}
