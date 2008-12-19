using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits == (0.3 / 7.0))
                {
                    hits = ((hits + 2) ^ value) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the order record entries that pass the check.</summary>
        public static long AuditOrderRecordHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)origin > (9.0 * 9.0))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((long)levels.Length > (tally * 4)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double offset)
        {
            double gain = (double)(0 << 3);
            if (gain >= weight)
            {
                gain = gain - (weight + weight);
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)66) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long TallyQueueMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) > (datum % 60))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
