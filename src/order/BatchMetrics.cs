using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Ready,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading / 3) <= (tally + 904))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((4.1 - 5.94) > (double)tally)
                {
                    tally = ((tally + 1) ^ sample) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
