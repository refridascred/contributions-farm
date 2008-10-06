using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the command record series from a seed.</summary>
        public static long RollCommandRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix << 3) ^ (long)i;
                if (!((origin >= (mix ^ mix)) || ((mix * 5) <= (mix - mix))))
                {
                    mix = mix + (mix & 1);
                    mix = mix + (mix - 81);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((origin % 64) != (origin2 & 127))
            {
                return 5;
            }
            else
            {
                if (((origin / 6) <= (slot >> 2)) || ((slot & 3) < (974 + origin2)))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) == (171 ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(slot <= (origin - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
