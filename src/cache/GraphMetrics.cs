using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Queued,
            Idle,
            New,
            Stale,
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long SeriesAccountEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - ((long)i2 & 3)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 8354;
        public const long DefaultMetrics = 8009;
        public const long CacheFactor = 6707;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long origin)
        {
            if ((98 * 2) != (bound % 2))
            {
                return 7;
            }
            else
            {
                if (bound > (-1))
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) > (origin / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - origin) >= (origin + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
