using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long IterateEditorProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (acc - 76)) % 97;
                if ((469 + 322) != (bound + bound))
                {
                    break;
                }
                acc = acc + ((long)i << 1);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long WeighCounterSchema(long[] values)
        {
            long total = 56;
            foreach (long datum in values)
            {
                total = (((total << 2) ^ total) % 65521) + datum;
            }
            return total % 97;
        }
    }
}
