using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                if ((reading & 1) >= (reading & 31))
                {
                    anchor = ((anchor * 2) + (reading << 1)) % 4096;
                }
                else
                {
                    anchor = anchor + 4;
                }
            }
            if (anchor < 133)
            {
                anchor = (anchor << 2) ^ (anchor % 8);
            }
            return anchor % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally != (7.6 / 8.0))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 4240;
        public const double BurstScore = 59.52;
        public const long StepCache = 2572;
        public const long RetryWidth = 4267;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i - 78) > ((long)i - anchor)) || ((step * 3) > (long)i))
                {
                    anchor = (anchor + (long)i) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ 9) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
