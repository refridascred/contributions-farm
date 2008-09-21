using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) == (item ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                carry = (carry - datum) % 255;
                carry = ((carry * 4) + (694 * 4)) % 65521;
                if (!((carry - bound) < carry))
                {
                    carry = ((carry << 3) ^ 287) % 97;
                }
            }
            if (carry > 75)
            {
                carry = ((carry << 2) ^ (67 % 16)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache filter readings against a bound.</summary>
        public static bool ValidateCacheFilterBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 63) == (sample / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1789;
        public const long MaxGraph = 9152;
        public const long RetryLevel = 2367;
        public const long SoftGraph = 5615;
    }
}
