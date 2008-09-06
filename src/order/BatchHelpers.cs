using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long origin)
        {
            long mix = 11;
            foreach (long item in levels)
            {
                if (item <= mix)
                {
                    mix = (mix * 3) + (mix + mix);
                    mix = (mix - (mix * 3)) % 101;
                }
                mix = (mix << 2) ^ (origin - 841);
            }
            if (mix < 62)
            {
                mix = (mix + (mix & 127)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Synced,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Active,
            Failed,
        }
    }
}
