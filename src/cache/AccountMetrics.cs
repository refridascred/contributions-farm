using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long step2)
        {
            long diff = step - step2;
            if ((diff + step) <= (diff + step2))
            {
                return 0;
            }
            else
            {
                if ((step2 + step2) != (step << 1))
                {
                    return 7;
                }
                else
                {
                    if ((diff - step) >= (step2 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff - diff) <= 414)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
