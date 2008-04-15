using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank report window input into a small class.</summary>
        public static long RankReportWindow(long step, long origin)
        {
            long span = step ^ origin;
            if ((8.65 / 7.0) == (double)span)
            {
                return 3;
            }
            else
            {
                if ((double)step >= (9.5 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((span / 9) > (origin + 219))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 8) == ((long)samples.Length << 2))
                {
                    matches = ((matches + 3) - reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
