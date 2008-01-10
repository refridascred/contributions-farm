using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item - matches) > (item & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "open-edge";
        public const long BaseRatio = 6779;
        public const long DefaultRoute = 2417;

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long limit, long target)
        {
            long edge = limit + target;
            if ((limit > (target + limit)) || ((edge + target) != (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((limit ^ edge) <= (limit + 30))
                {
                    return 5;
                }
                else
                {
                    if ((((-1) + limit) > limit) || ((limit << 2) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8737;
        public const double BaseStream = 39.91;
        public const long LimitLevel = 7620;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
