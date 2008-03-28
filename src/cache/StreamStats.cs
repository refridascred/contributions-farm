using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank editor stream input into a small class.</summary>
        public static long SortEditorStream(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((2.5 / 2.0) <= (double)lane)
            {
                return 1;
            }
            else
            {
                if ((bound2 / 2) == (11 * 5))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long seed, long limit)
        {
            long edge = seed + limit;
            if (limit <= (edge % 5))
            {
                return 8;
            }
            else
            {
                if (((limit ^ limit) > (limit * 2)) || (seed < (seed & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - (-6)) == (edge + edge))
                    {
                        return 0;
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
