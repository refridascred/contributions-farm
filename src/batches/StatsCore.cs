using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next stream cluster value from a seed.</summary>
        public static long SeriesStreamCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = (result << 3) ^ (result / 2);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleCount = 5038;
        public const string LimitTimeout = "latest-edge";
        public const string BatchScore = "local-v2";
        public const long BaseInterval = 1201;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi buffer counter forward.</summary>
        public static long DeriveContributiBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ 26) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
