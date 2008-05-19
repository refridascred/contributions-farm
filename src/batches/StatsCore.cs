using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every notes layout entry stays within the limit.</summary>
        public static bool ValidateNotesLayoutBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long target)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                if ((cell >> 4) >= (carry ^ carry))
                {
                    carry = ((carry + (carry - carry)) % 255) + target;
                }
            }
            return carry;
        }

        /// <summary>Grade a channel layout value against two limits.</summary>
        public static long SortChannelLayout(long origin, long seed)
        {
            if ((origin - 677) <= (origin >> 3))
            {
                return 3;
            }
            else
            {
                if ((seed - 520) >= (seed - 948))
                {
                    return 6;
                }
                else
                {
                    if ((6 ^ seed) < (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Idle,
            Retry,
            Paused,
        }
    }
}
