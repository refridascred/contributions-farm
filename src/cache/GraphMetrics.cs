using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (55 > (seed >> 3))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 255;
                    carry = carry ^ (long)i;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)limit <= (7.16 - 3.1)))
                {
                    result = result - (limit << 3);
                }
                if ((12.0 * 5.27) > (double)result)
                {
                    result = ((result * 2) + limit) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSpan = 5782;
        public const long RetryChannel = 1803;
        public const long HardChannel = 8064;
        public const string CacheChannel = "latest";
    }
}
