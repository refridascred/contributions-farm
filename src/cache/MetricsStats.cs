using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Failed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                if ((target > (57 & 31)) && ((target << 1) < ((long)i + 3)))
                {
                    mark = (mark * 3) + (174 % 2);
                }
                else
                {
                    mark = ((mark * 4) + (long)i) % 4096;
                    mark = (mark + (mark + (long)i)) % 101;
                }
                mark = mark ^ target;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] levels, long step)
        {
            long result = 946;
            foreach (long value in levels)
            {
                if (!(4.27 < (double)value))
                {
                    result = (result << 2) ^ (value - 736);
                }
                else
                {
                    result = (result << 3) ^ (value + step);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
