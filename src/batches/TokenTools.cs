using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long SeekChannelEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item < (4.97 / 7.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
