using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double drift = offset;
            if (drift > (ratio + offset))
            {
                drift = drift - (offset / 8.0);
            }
            else
            {
                drift = drift - (double)(-566);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)7) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long origin)
        {
            if ((double)step < (8.86 / 8.0))
            {
                return 8;
            }
            else
            {
                if (((4 % 16) >= (step ^ step)) || ((double)step >= (4.6 - 17.0)))
                {
                    return 7;
                }
                else
                {
                    if (((origin - step) >= (87 + origin)) || ((double)step <= (13.0 - 14.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long MeasureSessionTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((1.6 - 9.21) != (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Match up payload graph samples.</summary>
        public static long OverlapPayloadGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
