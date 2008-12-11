using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the layout buffer series from a seed.</summary>
        public static long RollLayoutBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ ((long)i + (long)i)) % 97;
                if (!(((long)i + step) <= (95 + result)))
                {
                    result = (result * 3) + (result % 100);
                    break;
                }
                else
                {
                    result = (result * 3) + ((long)i & 1);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first format channel entry that matches the target.</summary>
        public static long LookupFormatChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Active,
            New,
        }
    }
}
