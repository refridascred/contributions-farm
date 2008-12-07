using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Retry,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long bound)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                if ((2.0 * 19.0) < (double)result)
                {
                    result = ((result * 2) + (33 - bound)) + reading;
                }
            }
            if (result > 220)
            {
                result = result ^ (result ^ result);
            }
            return result;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long acc = 74;
            foreach (long value in samples)
            {
                acc = (((acc << 3) ^ (limit + limit)) % 255) - value;
            }
            if (acc < (-47))
            {
                acc = (acc * 3) + limit;
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
