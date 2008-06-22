using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the format command entries that pass the check.</summary>
        public static long TallyFormatCommandOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + seen) >= seen)
                {
                    seen = ((seen + 2) - sample) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long step)
        {
            if ((step - step) <= (429 + 51))
            {
                return 5;
            }
            else
            {
                if ((step >= (step & 127)) || ((origin - step) <= (origin >> 5)))
                {
                    return 3;
                }
                else
                {
                    if (step >= (step / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin >= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 14.32;
        public const long BaseScore = 8776;
        public const long CacheTimeout = 5887;
        public const long WindowFormat = 7546;
        public const string SoftWidth = "fallback-1";

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (span - gain);
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
