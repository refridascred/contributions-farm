using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitSpan = 67.02;
        public const double BatchCounter = 6.05;
        public const long HardCounter = 9878;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool GuardAlreadyRouteRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long limit)
        {
            if ((limit / 4) <= step)
            {
                return 8;
            }
            else
            {
                if ((step - step) <= step)
                {
                    return 2;
                }
                else
                {
                    if (!((105 >> 1) > step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - limit) > 749)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
