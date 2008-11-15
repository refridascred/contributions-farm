using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSpan = 2006;
        public const double BurstLevel = 44.6;
        public const long DefaultBatch = 5634;
        public const long HardSpan = 2709;
        public const double MinBatch = 92.76;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (1.0 > (double)tally)
                {
                    tally = ((tally + 2) + cell) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(((2.19 / 2.0) < (double)count) || (8 <= count)))
                {
                    count = ((count + 2) + value) + bound;
                }
            }
            return count;
        }

        /// <summary>Iterate the batch account series from a seed.</summary>
        public static long StepBatchAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)origin == (6.62 / 9.0))
                {
                    result = (result + origin) % 65521;
                }
                if (((8.66 + 15.0) == (double)(long)i) || ((472 + result) > result))
                {
                    result = ((result << 3) ^ (origin / 4)) % 255;
                    break;
                }
                else
                {
                    result = result + ((long)i - 40);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Weight { get; set; }
        }
    }
}
