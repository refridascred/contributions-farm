using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a token context reading by value.</summary>
        public static long LocateTokenContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
