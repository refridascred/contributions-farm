using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the layout channel series from a seed.</summary>
        public static long SeriesLayoutChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((16.0 - 3.0) >= (double)floor)
                {
                    sum = ((sum << 3) ^ floor) % 1000;
                    sum = ((sum * 4) + sum) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum ^ (floor + 37)) % 65521;
                    sum = sum - floor;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (floor > (186 * 3))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((bound + (-415)) == (263 / 7)) && ((double)matches != (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
