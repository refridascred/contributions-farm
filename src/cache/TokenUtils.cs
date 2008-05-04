using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 2) != ((long)readings.Length << 2))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum & 7) < (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
