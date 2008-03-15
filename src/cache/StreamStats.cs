using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count counter batches pairs that satisfy a relation.</summary>
        public static long MatchCounterBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 6687;
        public const string BaseBuffer = "strict-1";
        public const long SoftBudget = 6723;
        public const long BurstBuffer = 7670;

        /// <summary>Accumulate command cluster samples.</summary>
        public static long CombineCommandCluster(long[] series, long bound)
        {
            long sum = 769;
            foreach (long value in series)
            {
                sum = (sum ^ ((long)series.Length + value)) % 65521;
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - bound) % 97) - (long)i;
                }
                sum = (sum << 3) ^ (bound * 2);
            }
            if (sum > 4)
            {
                sum = (sum ^ ((long)series.Length * 5)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
