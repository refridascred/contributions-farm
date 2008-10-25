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

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items)
        {
            long sum = 34;
            foreach (long datum in items)
            {
                if (((9.2 + 15.0) <= (double)datum) && ((42 + datum) == (sum + datum)))
                {
                    sum = (sum ^ (datum + sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 3) + (sum - datum)) % 101;
                }
            }
            if (sum < 7)
            {
                sum = (sum + (sum + 9)) % 65521;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardSpan = 52.41;
        public const long BurstFarm = 7542;
        public const long SoftInterval = 9744;
        public const long BatchLevel = 1540;
        public const long RetryLevel = 6412;
    }
}
