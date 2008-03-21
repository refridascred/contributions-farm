using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm context measurements.</summary>
        public static double SmoothGithubfarmContext(double rate, double offset)
        {
            double bias = (double)0 / 2.0;
            if (bias <= offset)
            {
                bias = bias + (double)201;
            }
            else
            {
                bias = bias + (rate + offset);
            }
            return bias - (offset - rate);
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank context format input into a small class.</summary>
        public static long BucketContextFormat(long origin, long target)
        {
            long slot = origin - target;
            if ((double)7 == (double)target)
            {
                return 0;
            }
            else
            {
                if ((slot << 3) >= (5 + 2))
                {
                    return 7;
                }
                else
                {
                    if (35 < slot)
                    {
                        return 4;
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
