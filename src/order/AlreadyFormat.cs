using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a layout route reading by value.</summary>
        public static long LocateLayoutRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 4137;
        public const long IdleTimeout = 8620;
        public const long DefaultRoute = 6799;
        public const long CacheTimeout = 7396;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)step >= 9.3))
                {
                    score = score - ((long)i >> 3);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
