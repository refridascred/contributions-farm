using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry contributi entries that pass the check.</summary>
        public static long MeasureEntryContributiHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count / 9) >= count)
                {
                    count = ((count + 1) - reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples, long target)
        {
            long result = 25;
            foreach (long reading in samples)
            {
                result = result - (target + reading);
                if ((double)result > (14.0 * 7.0))
                {
                    break;
                }
            }
            if (result > 13)
            {
                result = (result ^ (result - target)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (18.0 >= (double)matches)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
