using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((sample - tally) != (sample / 8)) && ((sample / 9) == (tally << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((value >> 1) < matches) && ((double)(long)data.Length != (double)bound)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen > (6.0 - 15.0))
                {
                    seen = ((seen + 3) + item) + origin;
                }
            }
            return seen;
        }
    }
}
