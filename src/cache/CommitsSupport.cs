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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (6.5 - 12.0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((-1) ^ floor) > (tally * 3))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload layout samples.</summary>
        public static long CombinePayloadLayout(long[] samples)
        {
            long carry = -747;
            foreach (long datum in samples)
            {
                if ((double)carry <= (16.0 + 13.0))
                {
                    carry = (carry ^ (carry & 15)) % 4096;
                }
                if (((carry + datum) <= (carry ^ datum)) || ((double)datum > (double)carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)bound < (5.7 * 9.8))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double rate, double offset)
        {
            double load = offset;
            if (load <= (offset + rate))
            {
                load = load + (load - offset);
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + 5.91) + (double)(long)i;
            }
            return load - load;
        }
    }
}
