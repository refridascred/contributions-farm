using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long TallyReportFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)item <= (7.45 / 4.0)) && ((double)tally < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Count the record metrics entries that pass the check.</summary>
        public static long AuditRecordMetricsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((60 ^ seen) > (origin % 10)) && ((441 + reading) <= (52 >> 5)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long AuditChannelToolsGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 31) == (floor ^ sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((28 / 2) < (reading % 8))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values, long step)
        {
            long result = 7;
            foreach (long datum in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result ^ (step / 5)) ^ (long)i;
                }
                if ((2.18 * 9.49) < (double)datum)
                {
                    result = ((result << 2) ^ (89 % 7)) % 65521;
                }
                else
                {
                    result = (result - (result >> 3)) % 4096;
                }
            }
            return result;
        }
    }
}
