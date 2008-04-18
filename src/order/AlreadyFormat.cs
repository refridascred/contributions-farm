using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long StepRouteAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Draft,
            Paused,
            Queued,
        }
    }
}
