using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a contributi batches reading by value.</summary>
        public static long SeekContributiBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report already entry stays within the limit.</summary>
        public static bool VerifyReportAlreadyLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
