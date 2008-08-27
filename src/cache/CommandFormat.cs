using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches >= (item + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((double)count < 6.1) || ((double)item < 0.85))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((anchor >> 1) >= offset)
                {
                    anchor = (anchor + ((-330) - anchor)) % 101;
                    anchor = (anchor << 3) ^ offset;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
