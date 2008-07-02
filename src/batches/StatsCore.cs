using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long TallyCacheFilterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((668 ^ datum) > origin)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 5546;
        public const string SoftFactor = "primary";
        public const string HardCount = "open-1";

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double drift = (double)1 - (offset - 12.0);
            if (drift < (double)(-801))
            {
                drift = (drift - drift) - bias;
            }
            else
            {
                drift = drift - (1.5 / 4.0);
            }
            return drift - drift;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((long)samples.Length % 12) <= tally))
                {
                    tally = ((tally + 1) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
