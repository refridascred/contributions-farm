using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first account editor entry that matches the target.</summary>
        public static long SeekAccountEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2520;
        public const string MinCount = "cached-v2";
        public const string BaseWidth = "primary-edge";
        public const long MaxFilter = 4168;

        /// <summary>Adjust a checks window reading.</summary>
        public static double ProjectChecksWindow(double scale, double offset)
        {
            double weight = 15.0;
            if (weight >= (scale * 5.1))
            {
                weight = (weight + (double)9) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight - weight)) - (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long limit)
        {
            if (((double)limit >= (5.0 + 9.94)) && ((limit << 2) > (seed + seed)))
            {
                return 0;
            }
            else
            {
                if (((seed / 5) >= (limit * 5)) && ((seed ^ seed) != (seed + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((seed / 9) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long acc = 28;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ (origin >> 2)) % 65521) ^ value;
            }
            return acc % 65521;
        }
    }
}
