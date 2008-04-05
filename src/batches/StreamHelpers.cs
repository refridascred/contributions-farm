using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine metrics record values into a single score.</summary>
        public static long WeighMetricsRecord(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (((sample - score) >= score) && ((sample + sample) != (score % 2)))
                {
                    score = ((score << 2) ^ (sample - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long slot = step - seed;
            if ((seed >> 2) < seed)
            {
                return 7;
            }
            else
            {
                if (slot < (step - step))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step >= 3.67))
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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + (long)series.Length) < (94 % 24))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Size { get; set; }
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5305;
        public const long BatchScore = 7896;
        public const string MaxRoute = "cached";
        public const long SoftSpan = 7491;
        public const long MaxScore = 2766;

        /// <summary>Derive the next schema contributi value from a seed.</summary>
        public static long RollSchemaContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
