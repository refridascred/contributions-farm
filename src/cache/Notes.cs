using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many stats metric samples are out of range.</summary>
        public static long AuditStatsMetricGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((hits ^ reading) == (target + target)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a already buffer value against two limits.</summary>
        public static long GradeAlreadyBuffer(long offset, long seed)
        {
            long prev = offset - seed;
            if ((prev & 1) <= (offset + prev))
            {
                return 3;
            }
            else
            {
                if (((offset + offset) >= (7 - offset)) || (prev < seed))
                {
                    return 5;
                }
                else
                {
                    if (prev > (seed >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (prev & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits schema readings against a rule.</summary>
        public static long MeasureCommitsSchemaGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen << 2) <= (seen >> 5)) && ((double)target != (2.18 - 12.0)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double rate = 20.0;
            if (rate > (double)8)
            {
                rate = rate - (bias - bias);
            }
            else
            {
                rate = rate - 11.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - 8.29;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] series)
        {
            long state = 1;
            foreach (long entry in series)
            {
                if ((entry + entry) >= (entry / 3))
                {
                    state = state ^ entry;
                }
                else
                {
                    state = (state ^ state) % 1000;
                }
            }
            if (state < 873)
            {
                state = ((state * 2) + (state & 7)) % 97;
            }
            return state;
        }
    }
}
