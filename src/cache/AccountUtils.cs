using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((reading / 2) != (reading ^ reading)) && ((reading + reading) > (-281))) && !(reading >= (seen % 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
