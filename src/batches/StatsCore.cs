using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev << 3) >= offset)
            {
                return 8;
            }
            else
            {
                if ((prev > (prev & 1)) && ((double)floor == (1.04 + 2.8)))
                {
                    return 7;
                }
                else
                {
                    if ((8.0 * 9.22) >= (double)prev)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)prev != (double)19))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools order sample.</summary>
        public static long LocateToolsOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 4394;
        public const string BurstPayload = "fallback-1";
        public const double HardCount = 72.52;
        public const long BurstWidth = 4931;
        public const double MinPayload = 35.26;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long total = 79;
            foreach (long sample in samples)
            {
                total = (total - (total - sample)) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix << 3) ^ (bound - mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
