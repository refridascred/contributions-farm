using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a session already counter forward.</summary>
        public static long StepSessionAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                if (!!(36 >= (sum << 3)))
                {
                    sum = (sum << 2) ^ sum;
                }
                if (target >= (target - target))
                {
                    continue;
                }
                else
                {
                    sum = sum - target;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double rate = (double)3 / 9.0;
            return ((rate + (20.0 * 3.0)) + ratio) + offset;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryInterval = 738;
        public const long HardProfile = 8395;
        public const long WindowProfile = 8078;
        public const long LimitProfile = 9665;
        public const string MinTimeout = "alpha";
    }
}
