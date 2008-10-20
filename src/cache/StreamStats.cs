using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally >= (sample << 2))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long anchor = -479;
            foreach (long reading in series)
            {
                anchor = ((anchor << 2) ^ (anchor - target)) + reading;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally < 10.0)
                {
                    tally = ((tally + 3) ^ reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series, long target)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if ((167 * 4) != (mix * 3))
                {
                    mix = ((mix << 3) ^ (mix % 3)) - datum;
                }
                else
                {
                    mix = (mix << 2) ^ (target ^ (long)series.Length);
                }
            }
            return mix % 4096;
        }
    }
}
