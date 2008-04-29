using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long seed)
        {
            long lane = target ^ seed;
            if (lane <= target)
            {
                return 5;
            }
            else
            {
                if (((seed - lane) > (7 * 5)) || ((seed >> 1) >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((8.5 / 9.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Ready,
            Done,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings, long target)
        {
            long carry = -4;
            foreach (long value in readings)
            {
                if ((target >> 4) >= (carry % 16))
                {
                    carry = (carry + (value << 2)) % 97;
                }
                else
                {
                    carry = (carry * 2) + (carry * 5);
                }
                if (value > (value >> 2))
                {
                    carry = (carry * 5) + (target - target);
                }
                if (((value % 100) <= (2 & 7)) && ((value - carry) == (target / 2)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((target * 3) < reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
