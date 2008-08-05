using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stats farm samples.</summary>
        public static long ScoreStatsFarm(long[] series)
        {
            long result = 206;
            foreach (long item in series)
            {
                if ((4 - item) > (item + result))
                {
                    result = ((result << 2) ^ (item >> 4)) % 97;
                    result = ((result * 2) + (long)series.Length) % 65521;
                }
                if (!((result * 3) == (item - item)))
                {
                    result = (result << 2) ^ (result + result);
                }
                if (((result % 12) <= result) || ((result / 7) < (long)series.Length))
                {
                    break;
                }
            }
            if (result < 18)
            {
                result = (result - (result & 63)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 16) < step)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already window samples are out of range.</summary>
        public static long TallyAlreadyWindowOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((limit * 2) < (sample % 97)) || ((hits + hits) > (hits + limit))) || ((810 < (limit / 3)) || ((0.6 + 7.8) > (double)sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
