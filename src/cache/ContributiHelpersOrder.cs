using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long score = 814;
            foreach (long value in readings)
            {
                if (((value & 3) > (score + value)) && ((value * 2) == (value + value)))
                {
                    score = (score * 3) + (value / 6);
                }
                if (score <= (343 >> 5))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples, long limit)
        {
            long total = 512;
            foreach (long reading in samples)
            {
                total = (((total * 5) + total) ^ reading) + limit;
            }
            if (total < 890)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) > (count / 9))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
