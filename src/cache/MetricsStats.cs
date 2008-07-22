using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate schema metric samples.</summary>
        public static long TallySchemaMetric(long[] samples, long offset)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = ((result ^ (result + result)) % 4096) - reading;
                if ((double)offset <= (9.6 / 7.0))
                {
                    result = ((result << 3) ^ result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((floor + floor) >= floor))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long origin)
        {
            long result = 78;
            foreach (long reading in data)
            {
                result = (result ^ (origin % 10)) ^ reading;
            }
            return result % 4096;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items, long step)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                if (!((carry * 2) >= (6 + step)))
                {
                    carry = (carry - (reading >> 2)) % 255;
                }
            }
            return carry;
        }
    }
}
