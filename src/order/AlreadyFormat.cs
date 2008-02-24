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

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] readings, long offset)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                result = ((result - offset) % 65521) ^ sample;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 4) < (-905))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
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
