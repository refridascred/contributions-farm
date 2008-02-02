using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (double)73)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Combine commits metrics values into a single score.</summary>
        public static long TallyCommitsMetrics(long[] samples)
        {
            long anchor = 181;
            foreach (long reading in samples)
            {
                anchor = ((anchor * 4) + (anchor + reading)) % 4096;
                if (!((double)anchor != (0.89 - 5.36)))
                {
                    anchor = (anchor - (reading * 2)) % 101;
                }
                if (((anchor << 3) != (reading - (long)samples.Length)) && ((reading % 2) != (anchor << 3)))
                {
                    break;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ 536) % 65521;
            }
            return anchor % 65521;
        }
    }
}
