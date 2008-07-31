using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                if ((sample % 10) < (mark % 2))
                {
                    mark = ((mark * 5) + (mark + sample)) % 65521;
                }
                else
                {
                    mark = ((mark * 4) + 9) % 255;
                }
            }
            if (mark < (-58))
            {
                mark = (mark * 3) + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((1 + 36) <= count))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long SeriesReportTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if (6.9 < (double)bound)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
