using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long origin, long floor)
        {
            if ((floor ^ origin) > floor)
            {
                return 3;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if (((origin ^ origin) < origin) || ((floor % 5) > 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(value > (tally / 9)))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + matches) > matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
