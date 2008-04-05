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

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchTimeout = "staging-v2";
        public const string BurstCount = "latest-v2";
        public const long StepScore = 4264;
        public const long IdleBatch = 4200;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((4.0 + 3.92) != (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long seed)
        {
            long diff = step ^ seed;
            if (diff < (step >> 2))
            {
                return 3;
            }
            else
            {
                if (seed > (step & 255))
                {
                    return 5;
                }
                else
                {
                    if ((diff ^ step) < ((-25) + diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-73) < diff) || ((diff - 981) >= 520))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
