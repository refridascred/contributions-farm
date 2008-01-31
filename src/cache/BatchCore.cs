using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long total = 903;
            foreach (long reading in samples)
            {
                if (!(reading < (reading + total)))
                {
                    total = total - (reading / 5);
                }
            }
            return total;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values)
        {
            long mix = 31;
            foreach (long datum in values)
            {
                if (mix > datum)
                {
                    mix = (mix - (datum + datum)) % 65521;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 2) ^ (mix * 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Draft,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((bound * 4) == (matches * 5)) && ((17.0 + 0.8) >= (double)bound)) || ((double)matches >= (7.41 * 3.4)))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }
    }
}
