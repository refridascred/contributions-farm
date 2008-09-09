using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long mix = 908;
            foreach (long value in values)
            {
                mix = (mix * 4) + value;
            }
            if (mix > 5)
            {
                mix = ((mix * 2) + (mix >> 1)) % 255;
            }
            return mix % 1000;
        }
    }
}
