using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "fallback-1";
        public const string MaxSpan = "stable-edge";
        public const string SoftChannel = "alpha";
        public const long WindowChannel = 6808;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long offset)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((double)datum <= 2.4)
                {
                    mix = (((mix << 3) ^ (744 ^ datum)) % 65521) - offset;
                }
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (origin >= 555)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - ((-5) * 4)) % 101) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
