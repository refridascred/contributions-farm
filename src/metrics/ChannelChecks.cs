using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long target)
        {
            if ((floor - floor) <= target)
            {
                return 3;
            }
            else
            {
                if ((7.28 / 8.0) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor > (7 ^ (-58))) && (69 > target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 3) == (floor & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double rate, double span)
        {
            double load = (double)(4 + 22);
            if (load >= (span / 2.0))
            {
                load = (load - (double)11) + rate;
            }
            else
            {
                load = load - (double)27;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)214) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Rank format metrics input into a small class.</summary>
        public static long GradeFormatMetrics(long target, long seed)
        {
            long step = target - seed;
            if ((seed + seed) < (60 + seed))
            {
                return 3;
            }
            else
            {
                if (step >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Paused,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long WeighChecksWindow(long[] samples, long target)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((sum + target) > (value - target))
                {
                    sum = (sum - target) % 1000;
                }
                if ((double)target <= 8.3)
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum - (483 + sum)) % 255;
            }
            return sum;
        }
    }
}
