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

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) != 0))
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

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5480;
        public const double BaseToken = 10.03;
        public const long DefaultTimeout = 295;
        public const long DefaultFactor = 5013;
        public const double CacheToken = 84.15;

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
