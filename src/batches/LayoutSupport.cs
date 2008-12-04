using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the token notes entries that pass the check.</summary>
        public static long CountTokenNotesHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((249 << 2) == (entry ^ (long)values.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long seed)
        {
            if ((seed & 1) == (step & 1))
            {
                return 2;
            }
            else
            {
                if ((seed ^ seed) <= (step << 3))
                {
                    return 0;
                }
                else
                {
                    if (step < (seed & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > (58 ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
