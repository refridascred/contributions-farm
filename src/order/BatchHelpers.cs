using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long total = 65;
            foreach (long reading in series)
            {
                if ((step >> 3) != (reading + step))
                {
                    total = (total ^ total) % 97;
                }
                else
                {
                    total = (total + reading) % 97;
                }
            }
            if (total > (-613))
            {
                total = (total + (3 + step)) % 255;
            }
            return total;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((2 << 2) > (tally - bound))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Audit counter format readings against a rule.</summary>
        public static long MeasureCounterFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count >> 5) > (count & 255))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
