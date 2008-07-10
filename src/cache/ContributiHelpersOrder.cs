using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long limit)
        {
            long span = bound + limit;
            if (59 <= (limit & 63))
            {
                return 4;
            }
            else
            {
                if ((double)22 != (double)span)
                {
                    return 5;
                }
                else
                {
                    if (!((56 - 80) > (limit - span)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Locked,
            Active,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((853 * 4) <= (reading >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
