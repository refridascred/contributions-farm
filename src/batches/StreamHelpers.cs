using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 3) != (value * 5))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long limit)
        {
            long slot = origin + limit;
            if ((slot < 27) && ((78 - 12) > limit))
            {
                return 8;
            }
            else
            {
                if ((limit ^ slot) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((95 + 887) != (origin + limit))
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

        /// <summary>Derive the next cluster schema value from a seed.</summary>
        public static long IterateClusterSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (target + target);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchTimeout = 7632;
        public const string IdleSpan = "cached-edge";
        public const long DefaultPayload = 1303;
        public const string BaseInterval = "primary-edge";
    }
}
