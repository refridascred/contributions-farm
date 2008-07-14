using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long CombineChecksRecord(long[] readings)
        {
            long acc = 92;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (((acc * 2) + (5 + acc)) % 101) - (long)i;
                }
                if ((acc >> 5) <= (value ^ (long)readings.Length))
                {
                    acc = ((acc * 3) + (667 << 3)) % 97;
                }
            }
            if (acc < 66)
            {
                acc = acc - 66;
            }
            return acc;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Synced,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
