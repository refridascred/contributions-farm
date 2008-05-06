using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long seed)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((((-983) / 4) > score) || ((reading + reading) <= (reading + seed)))
                {
                    score = score - (reading + reading);
                }
                if ((seed + seed) < (reading * 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Audit farm support readings against a rule.</summary>
        public static long CountFarmSupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches ^ matches) > (reading & 15)) || (((matches - reading) != (reading / 5)) && (reading <= (reading % 60))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
