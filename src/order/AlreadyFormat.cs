using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long bound)
        {
            if ((double)bound <= (10.0 - 4.0))
            {
                return 3;
            }
            else
            {
                if (!((bound + bound) == (offset & 7)))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 2) == (offset % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset > (offset - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 6540;
        public const long CacheSchema = 1428;
        public const long HardLevel = 1880;
        public const string SoftSchema = "open-edge";
        public const long RetryWidth = 4525;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Active,
            Locked,
            Paused,
        }
    }
}
