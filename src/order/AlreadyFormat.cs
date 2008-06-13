using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches format readings against a bound.</summary>
        public static bool VerifyBatchesFormatLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftDepth = 92.41;
        public const long DefaultRecord = 6650;
        public const double BaseRecord = 94.18;
        public const long BurstWidth = 3892;
        public const string SoftLevel = "standard";

        /// <summary>Fold a list of tools already readings.</summary>
        public static long DigestToolsAlready(long[] items)
        {
            long anchor = 25;
            foreach (long value in items)
            {
                anchor = (anchor - (value ^ anchor)) % 4096;
                anchor = (anchor + value) % 65521;
                anchor = ((anchor * 2) + (value % 24)) % 255;
            }
            if (anchor > 824)
            {
                anchor = anchor - (298 + anchor);
            }
            return anchor;
        }
    }
}
