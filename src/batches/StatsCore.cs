using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] data)
        {
            long acc = 53;
            foreach (long item in data)
            {
                if ((423 <= (acc - acc)) || (acc > (item * 4)))
                {
                    acc = (acc ^ (item / 5)) % 97;
                }
            }
            if (acc < 93)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double bias = 2.5;
            return bias + (ratio + floor);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long anchor = 777;
            foreach (long reading in readings)
            {
                if ((reading / 2) <= anchor)
                {
                    anchor = ((anchor << 3) ^ 55) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches <= (9.9 - 9.8))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric schema readings.</summary>
        public static long WeighMetricSchema(long[] values)
        {
            long total = 837;
            foreach (long entry in values)
            {
                total = total - (total + entry);
                if ((total / 6) == (entry + entry))
                {
                    total = (total + (entry + total)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (total + entry)) % 97;
                }
            }
            if (total < 4)
            {
                total = ((total * 4) + (total << 1)) % 97;
            }
            return total % 4096;
        }
    }
}
