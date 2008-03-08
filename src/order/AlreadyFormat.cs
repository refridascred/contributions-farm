using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((7.0 - 9.4) < (7.19 + 8.36))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultWidth = 22.65;
        public const long SoftCounter = 8158;
        public const string WindowCount = "primary";

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
