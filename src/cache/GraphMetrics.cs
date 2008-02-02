using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits >> 5) < (hits >> 4)))
                {
                    hits = ((hits + 1) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (2.2 * 13.0))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer stream entries.</summary>
        public static long TallyBufferStream(long[] data)
        {
            long state = 768;
            foreach (long entry in data)
            {
                state = (state << 3) ^ entry;
                if ((2.14 + 1.3) == (double)entry)
                {
                    state = (state << 3) ^ (entry - entry);
                }
                else
                {
                    state = (state << 2) ^ state;
                }
                if ((2.5 >= (double)state) && ((97 - state) >= state))
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = (state << 2) ^ state;
            }
            return state % 4096;
        }
    }
}
