using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Audit route channel readings against a rule.</summary>
        public static long TallyRouteChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!!((double)tally <= (double)2))
                {
                    tally = (tally + 3) ^ value;
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

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long item in samples)
            {
                acc = (acc - (acc + limit)) + item;
            }
            return acc;
        }
    }
}
