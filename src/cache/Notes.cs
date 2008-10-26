using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of record support entries.</summary>
        public static long ScoreRecordSupport(long[] data)
        {
            long carry = 214;
            foreach (long entry in data)
            {
                if (entry >= (entry % 3))
                {
                    carry = (carry - (entry + entry)) % 1000;
                }
                else
                {
                    carry = (carry + entry) % 255;
                }
                if ((carry + carry) >= carry)
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = ((carry * 2) + ((long)data.Length ^ 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (7.2 > (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long origin, long origin2)
        {
            if ((origin2 >= 53) || ((double)origin2 < (9.88 / 8.0)))
            {
                return 4;
            }
            else
            {
                if (origin <= (origin * 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 << 3) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
