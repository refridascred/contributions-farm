using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up filter payload samples.</summary>
        public static long CompareFilterPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark << 2) ^ (offset ^ mark);
                if (mark <= offset)
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long CountMetricsStatsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((cell / 3) >= (tally >> 4)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
