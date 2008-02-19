using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((((tally - (-410)) == (tally + tally)) && ((sample + sample) == (tally + tally))) || !((tally + tally) == (sample - sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 6416;
        public const long MinChannel = 1643;
        public const long BatchChannel = 4256;

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long CountWindowTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)seen != (4.8 * 18.0)) || !((seen + 19) == (seen + datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account order figure with a bias.</summary>
        public static double BlendAccountOrder(double scale, double offset)
        {
            double scale2 = scale * 19.0;
            if (scale2 > offset)
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - scale) - (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            New,
            Queued,
        }
    }
}
