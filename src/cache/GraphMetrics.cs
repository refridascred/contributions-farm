using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry / 4) <= (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema window samples.</summary>
        public static long WeighSchemaWindow(long[] readings)
        {
            long mix = 51;
            foreach (long reading in readings)
            {
                if ((reading & 63) < reading)
                {
                    mix = ((mix * 2) + (mix * 2)) % 1000;
                    break;
                }
                if ((reading >> 2) <= mix)
                {
                    mix = ((mix << 3) ^ (reading + reading)) % 65521;
                }
                else
                {
                    mix = (mix ^ (mix << 1)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 1537;
        public const long MaxSpan = 6601;
        public const long BatchWidth = 8707;
        public const long SoftSize = 6067;
        public const string CacheInterval = "fallback-1";

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long BucketSchemaEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((seed * 5) >= (step + seed))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) > diff)
                {
                    return 6;
                }
                else
                {
                    if ((2.7 / 8.0) > (double)diff)
                    {
                        return 0;
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
