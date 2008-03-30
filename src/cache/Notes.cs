using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Retry,
            Synced,
            New,
            Done,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long step)
        {
            long carry = 92;
            foreach (long value in items)
            {
                carry = ((carry + (512 ^ carry)) ^ value) - step;
                carry = (carry - (carry >> 1)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4708;
        public const long RetryQueue = 8774;
        public const long BatchRatio = 8902;
        public const long SoftTimeout = 9047;
        public const double WindowQueue = 88.6;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 91;
            foreach (long value in series)
            {
                mark = ((mark + (7 >> 4)) % 1000) + value;
            }
            if (mark < 435)
            {
                mark = (mark + floor) % 255;
            }
            return mark % 1000;
        }
    }
}
