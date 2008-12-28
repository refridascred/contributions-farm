using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a editor channel sample.</summary>
        public static long LocateEditorChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "open-v2";
        public const long BatchPayload = 8435;
        public const long BurstPayload = 2704;
        public const long HardPayload = 9166;
        public const long StepLevel = 7814;
    }
}
