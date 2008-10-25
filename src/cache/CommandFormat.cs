using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples, long seed)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if (1.92 <= (double)seed)
                {
                    mix = (mix + (mix >> 4)) + datum;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ (seed - 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series)
        {
            long anchor = 932;
            foreach (long cell in series)
            {
                if ((anchor / 2) >= (anchor >> 2))
                {
                    anchor = (anchor ^ cell) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardSpan = 52.41;
        public const long BurstFarm = 7542;
        public const long SoftInterval = 9744;
        public const long BatchLevel = 1540;
        public const long RetryLevel = 6412;
    }
}
