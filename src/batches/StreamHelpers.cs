using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Project the next entry metric value.</summary>
        public static double SmoothEntryMetric(double scale, double floor)
        {
            double weight = 5.96;
            if (weight >= floor)
            {
                weight = weight - (scale / 2.0);
            }
            return weight + (scale * 8.0);
        }

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long AuditSchemaBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count > (reading >> 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long anchor = -5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor * 4) + ((long)i / 9);
                }
                anchor = (anchor ^ (anchor % 60)) % 255;
                if ((double)sample < (7.21 / 8.0))
                {
                    anchor = (anchor + (sample + sample)) % 101;
                }
                else
                {
                    anchor = anchor - (sample - sample);
                }
            }
            if (anchor < 18)
            {
                anchor = (anchor ^ (4 & 7)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen >> 4) == (seen + value))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
