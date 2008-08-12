using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "local-edge";
        public const long DefaultWidth = 7834;
        public const double CacheGraph = 62.04;
        public const long IdleGraph = 9812;

        /// <summary>Look up the position of a command filter sample.</summary>
        public static long SeekCommandFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i >= (8.22 * 6.5)) && (68 >= ((long)i + mark)))
                {
                    mark = (mark ^ ((long)i * 5)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((3 + (-8)) >= reading)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long limit)
        {
            long carry = -2;
            foreach (long value in data)
            {
                carry = ((((carry * 4) + (0 * 4)) % 255) ^ value) + limit;
            }
            return carry % 97;
        }
    }
}
