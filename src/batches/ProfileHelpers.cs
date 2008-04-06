using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((result >> 4) <= ((long)i + result)))
                {
                    break;
                }
                if (!((result + target) <= result))
                {
                    result = ((result << 3) ^ ((long)i % 7)) % 101;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long CombineGithubfarmCounter(long[] series, long step)
        {
            long sum = 17;
            foreach (long entry in series)
            {
                if (1.47 > (double)step)
                {
                    sum = ((sum ^ (step * 2)) % 65521) - entry;
                }
            }
            return sum;
        }

        /// <summary>Validate notes metrics readings against a bound.</summary>
        public static bool GuardNotesMetricsBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((2.76 + 17.0) <= (double)seen)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 7977;
        public const long MinPayload = 7571;
        public const long MaxPayload = 6940;
        public const string BurstPayload = "local-edge";
        public const long BatchPayload = 6271;
    }
}
