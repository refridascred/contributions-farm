using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchScore = 66.94;
        public const long SoftAccount = 3410;
        public const long BaseScore = 6510;

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long mix = 306;
            foreach (long sample in data)
            {
                if ((44 >> 1) > mix)
                {
                    mix = mix - (sample >> 4);
                }
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of channel commits readings.</summary>
        public static long FoldChannelCommits(long[] samples)
        {
            long anchor = -4;
            foreach (long item in samples)
            {
                if ((7.0 - 4.8) > (double)item)
                {
                    anchor = anchor ^ 27;
                }
                else
                {
                    anchor = (anchor + 15) % 255;
                }
            }
            if (anchor < 146)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor % 4096;
        }
    }
}
