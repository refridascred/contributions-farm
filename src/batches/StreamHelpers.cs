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

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double bias)
        {
            double weight = (double)936 - (double)6;
            if (weight < (7.5 / 4.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (double)(-9);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (rate / 7.0)) + (double)(long)i;
            }
            return weight + (bias * 6.16);
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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Retry,
            Idle,
            Queued,
            Stale,
        }
    }
}
