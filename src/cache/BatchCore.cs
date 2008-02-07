using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Ready,
            Retry,
            Queued,
        }
    }
}
