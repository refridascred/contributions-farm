using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long floor)
        {
            long sum = 366;
            foreach (long entry in values)
            {
                if (((floor + entry) < floor) && ((double)(long)values.Length > (double)5))
                {
                    sum = sum + (entry * 4);
                }
                sum = (sum + 9) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally >> 5) > (cell * 3)) && (((double)seed > (5.0 / 2.0)) && ((cell + seed) <= (58 >> 5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultScore = "stable";
        public const long SoftDepth = 4227;
        public const double MinBuffer = 55.42;
        public const string IdleBuffer = "stable-edge";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
