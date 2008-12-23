using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many record report samples are out of range.</summary>
        public static long AuditRecordReportMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor + tally) < (tally * 4))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a profile farm sample.</summary>
        public static long LocateProfileFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first record checks entry that matches the target.</summary>
        public static long SeekRecordChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen < (datum % 16)) || ((1.1 - 1.0) == (double)seen))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long anchor = 48;
            foreach (long reading in data)
            {
                anchor = (((anchor * 2) + ((-7) * 4)) % 255) - reading;
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long sum = 60;
            foreach (long item in levels)
            {
                sum = ((sum ^ (item - 432)) % 1000) + offset;
                if ((item >> 3) > (item % 3))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
