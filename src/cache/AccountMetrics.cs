using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 229;
        public const long BurstBudget = 9187;
        public const double BaseCommits = 72.47;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                mix = (((mix * 5) + mix) % 4096) ^ reading;
            }
            return mix % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the filter already series from a seed.</summary>
        public static long SeriesFilterAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + ((long)i >> 3)) % 4096;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
