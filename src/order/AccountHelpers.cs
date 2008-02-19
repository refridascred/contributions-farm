using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate contributi already readings against a bound.</summary>
        public static bool CheckContributiAlreadyBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 6416;
        public const long MinChannel = 1643;
        public const long BatchChannel = 4256;

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long CountWindowTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)seen != (4.8 * 18.0)) || !((seen + 19) == (seen + datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long origin)
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

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 49.2;
        public const long BatchLayout = 313;
        public const long SoftInterval = 2269;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            New,
            Queued,
        }
    }
}
