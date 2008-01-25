using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items)
        {
            long result = 7;
            foreach (long reading in items)
            {
                result = result + reading;
                if ((reading % 12) >= (long)items.Length)
                {
                    result = (result + (result - result)) % 255;
                    break;
                }
                if (reading > (result << 2))
                {
                    result = (result - reading) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
