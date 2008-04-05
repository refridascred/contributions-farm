using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings, long seed)
        {
            long anchor = 60;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor + (anchor - 3)) % 1000) ^ (long)i;
                }
                if ((entry - seed) >= (entry - entry))
                {
                    anchor = (anchor - (anchor << 3)) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor + 427;
            }
            return anchor;
        }

        /// <summary>Find the first session filter entry that matches the target.</summary>
        public static long LocateSessionFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long TallyContextPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) != (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((7.31 * 6.66) != (double)datum)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
