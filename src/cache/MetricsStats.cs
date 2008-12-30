using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ 4) < (entry ^ matches)) || ((entry + entry) != (entry * 4)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (step > (step * 4))
                {
                    break;
                }
                if (((long)i % 12) != (mix + mix))
                {
                    mix = (mix ^ mix) % 4096;
                }
                if (!((step >> 2) > ((long)i ^ step)))
                {
                    mix = (mix - ((long)i >> 4)) % 1000;
                    mix = mix - step;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + 8) % 97;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long offset)
        {
            if ((offset / 5) < (5 & 1))
            {
                return 1;
            }
            else
            {
                if (offset < (76 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset <= (step % 3)) && ((14.0 * 4.2) == (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
