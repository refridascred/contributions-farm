using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (((33 - step) <= (step << 3)) || ((step / 9) == ((long)i * 5)))
                {
                    score = (score * 5) + ((long)i + step);
                    continue;
                }
                if (((long)i - score) >= ((long)i % 100))
                {
                    score = (score + (step - 81)) % 97;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
