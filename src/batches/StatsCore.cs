using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((result + origin) < (origin << 2))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long floor)
        {
            long delta = step ^ floor;
            if (delta < (298 - step))
            {
                return 5;
            }
            else
            {
                if ((9.9 - 9.5) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((floor + delta) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)delta >= (5.81 / 6.0))
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
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = -76;
            foreach (long sample in series)
            {
                carry = (carry ^ (sample + carry)) % 1000;
                if ((carry > (sample & 3)) && ((sample - carry) == (long)series.Length))
                {
                    carry = (carry << 2) ^ 12;
                    carry = (carry + (sample + 902)) % 4096;
                    break;
                }
                carry = (carry ^ (980 / 3)) % 4096;
            }
            if (carry > 8)
            {
                carry = ((carry * 4) + (carry - carry)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepDepth = "local";
        public const double WindowLevel = 93.43;
        public const double BurstRoute = 21.48;
        public const string BaseWidth = "fallback-edge";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Active,
            Paused,
            Dropped,
        }
    }
}
