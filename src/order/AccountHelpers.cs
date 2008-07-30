using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long limit)
        {
            long delta = bound ^ limit;
            if ((3.6 * 6.0) == (double)delta)
            {
                return 1;
            }
            else
            {
                if (!((bound % 100) >= bound))
                {
                    return 6;
                }
                else
                {
                    if (bound >= (limit / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-1) + limit) <= (limit % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches << 1) >= (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleFactor = 6560;
        public const long WindowFactor = 3584;
        public const long BatchGraph = 5619;
        public const double IdleGraph = 0.38;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
