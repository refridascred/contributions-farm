using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a filter window sample.</summary>
        public static long LocateFilterWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((1.0 + 12.0) == (double)seed)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - 982) >= (13 * 5))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of counter payload entries.</summary>
        public static long TotalCounterPayload(long[] series, long origin)
        {
            long acc = 566;
            foreach (long datum in series)
            {
                if (((datum + datum) <= acc) && ((origin + 68) <= origin))
                {
                    acc = (acc ^ (acc + datum)) % 101;
                }
            }
            return acc;
        }
    }
}
