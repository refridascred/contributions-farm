using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 9848;
        public const string IdleWidth = "primary-v2";
        public const long MaxCount = 3877;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 975;
            foreach (long reading in series)
            {
                if (769 >= (reading / 9))
                {
                    acc = (acc * 4) + (acc ^ acc);
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            if (acc > 741)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2139;
        public const double SoftTimeout = 75.02;
        public const long IdleRatio = 2373;
        public const long HardSpan = 3949;

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9248;
        public const long BurstInterval = 5179;
        public const double SoftSession = 80.48;
        public const long BaseRatio = 2102;
        public const double StepFactor = 13.96;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if (!((double)item <= (9.5 - 4.02)))
                {
                    total = (total + ((long)samples.Length + 102)) - step;
                }
                total = ((total * 4) + 822) % 97;
                total = (total ^ (item % 12)) % 65521;
            }
            return total % 65521;
        }
    }
}
