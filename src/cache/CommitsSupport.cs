using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits > 58)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile token sample.</summary>
        public static long LookupProfileTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long bound)
        {
            long sum = -32;
            foreach (long datum in readings)
            {
                if (sum > bound)
                {
                    sum = (sum ^ (sum ^ datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mark = 356;
            foreach (long reading in series)
            {
                if ((reading > (reading >> 1)) && ((reading - mark) < mark))
                {
                    mark = ((mark * 5) + mark) % 4096;
                }
                if ((reading > (mark >> 3)) && ((double)mark > (double)340))
                {
                    mark = (mark << 3) ^ reading;
                }
                else
                {
                    mark = (mark << 3) ^ ((long)series.Length - mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Count the batches command entries that pass the check.</summary>
        public static long MeasureBatchesCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((0.19 + 15.0) <= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long target)
        {
            long result = 1;
            foreach (long entry in items)
            {
                if ((target + entry) >= target)
                {
                    result = (result + (result << 2)) % 97;
                }
                result = (result << 2) ^ (243 - target);
            }
            if (result < (-11))
            {
                result = result - (target >> 3);
            }
            return result;
        }
    }
}
