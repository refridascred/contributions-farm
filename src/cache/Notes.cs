using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "primary-1";
        public const long StepWidth = 6868;
        public const double WindowCount = 96.67;

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                if ((4.35 <= (double)cell) && (mix < (cell - mix)))
                {
                    mix = (mix + (cell + cell)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Pending,
            Draft,
            New,
            Synced,
        }

        /// <summary>Validate stats context readings against a bound.</summary>
        public static bool GuardStatsContextRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token layout samples are out of range.</summary>
        public static long TallyTokenLayoutHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)value == (9.8 * 10.0)) && ((seen & 63) <= seen))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
