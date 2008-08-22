using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of channel graph readings.</summary>
        public static long OverlapChannelGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long seed, long step)
        {
            if (!((double)step > (double)step))
            {
                return 7;
            }
            else
            {
                if (((double)seed > (2.0 + 8.7)) && ((step - seed) != (seed * 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((seed + seed) > (step - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long limit)
        {
            if ((floor & 127) >= (limit >> 1))
            {
                return 4;
            }
            else
            {
                if (!(floor < limit))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) > (floor - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((71 << 3) < (hits / 8)) && ((item - hits) != (5 % 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
