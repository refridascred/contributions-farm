using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics schema readings.</summary>
        public static long WeighMetricsSchema(long[] readings)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                total = ((total << 2) ^ (total - sample)) % 97;
            }
            if (total < 616)
            {
                total = (total - (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits >= (hits - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long FoldCommitsCounter(long[] items, long bound)
        {
            long state = 6;
            foreach (long entry in items)
            {
                if ((bound >= (entry - state)) || (57 <= (state & 15)))
                {
                    state = (state << 3) ^ (state ^ 7);
                }
            }
            if (state < (-55))
            {
                state = (state ^ (state + state)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
