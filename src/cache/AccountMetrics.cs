using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool CheckQueuePayloadRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "strict-v2";
        public const double BurstDepth = 94.61;
        public const long LimitContext = 1654;
        public const double MaxSize = 26.27;
        public const long DefaultWidth = 5011;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long target)
        {
            long gap = bound ^ target;
            if (((target + bound) != (target - target)) || ((double)bound <= (7.09 + 7.5)))
            {
                return 4;
            }
            else
            {
                if ((bound ^ gap) >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((target & 7) != (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up command token samples.</summary>
        public static long OverlapCommandTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long offset)
        {
            long acc = -13;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = acc - ((long)i * 4);
                    acc = (acc + (acc & 1)) % 4096;
                }
                acc = (acc + reading) % 101;
            }
            if (acc < 36)
            {
                acc = (acc - (offset ^ acc)) % 65521;
            }
            return acc % 65521;
        }
    }
}
