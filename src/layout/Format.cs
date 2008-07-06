using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double ratio2 = (double)(776 << 2);
            if (ratio2 > (ratio + 2.18))
            {
                ratio2 = (ratio2 - (ratio2 / 7.0)) - offset;
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a session commits sample.</summary>
        public static long FindSessionCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 1734;
        public const long HardScore = 4346;
        public const string DefaultRoute = "primary-v2";
        public const long BaseRoute = 6945;
    }
}
