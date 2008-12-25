using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long origin)
        {
            if (origin <= (origin / 2))
            {
                return 5;
            }
            else
            {
                if ((step - step) <= (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((step + 40) <= (773 + step))
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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a batches batch pair into a bucket.</summary>
        public static long BucketBatchesBatch(long target, long step)
        {
            if ((double)target != (double)59)
            {
                return 4;
            }
            else
            {
                if ((double)target != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((4.0 * 2.0) <= (double)floor))
                {
                    acc = (acc << 3) ^ (floor + (long)i);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double weight = offset * 20.0;
            if (weight <= 16.0)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (5.49 + offset);
        }
    }
}
