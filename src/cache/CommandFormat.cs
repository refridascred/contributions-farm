using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm queue value against two limits.</summary>
        public static long BucketFarmQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((limit + limit) == (target & 31))
            {
                return 4;
            }
            else
            {
                if ((target - 86) < (diff ^ limit))
                {
                    return 6;
                }
                else
                {
                    if (((target * 2) > (limit * 3)) && ((target - diff) >= (diff + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target - diff) >= diff) || (458 <= diff))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 9055;
        public const string BurstReport = "standard-edge";
        public const long StepFactor = 2781;
        public const string HardCount = "local";
        public const long LimitSpan = 263;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
