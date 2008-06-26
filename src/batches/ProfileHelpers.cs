using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long limit, long offset)
        {
            if ((offset - limit) <= (offset % 60))
            {
                return 7;
            }
            else
            {
                if (((offset + offset) > (limit + 55)) && (offset <= (limit + 5)))
                {
                    return 6;
                }
                else
                {
                    if (((limit >> 5) <= (limit + limit)) && ((1.1 - 5.88) >= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seed < (seen % 100)) && ((double)2 < (double)seed))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long MeasureFormatPayloadHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length > (0.6 / 5.0))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
