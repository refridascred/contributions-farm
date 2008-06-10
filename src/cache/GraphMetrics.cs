using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings, long floor)
        {
            long total = 982;
            foreach (long item in readings)
            {
                if (!((total & 15) != (222 ^ total)))
                {
                    total = ((total + floor) % 97) + item;
                }
            }
            if (total > 71)
            {
                total = (total + (floor + total)) % 255;
            }
            return total;
        }

        /// <summary>Rank context graph input into a small class.</summary>
        public static long SortContextGraph(long offset, long origin)
        {
            long lane = offset - origin;
            if ((lane << 3) != (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if ((6.6 / 4.0) < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (lane >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels, long target)
        {
            long result = -86;
            foreach (long reading in levels)
            {
                if (((8.98 - 7.1) == (double)result) || ((-722) < (long)levels.Length))
                {
                    result = ((result + result) - reading) - target;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank stream context input into a small class.</summary>
        public static long SortStreamContext(long step, long bound)
        {
            long prev = step ^ bound;
            if ((step & 63) == (prev >> 3))
            {
                return 7;
            }
            else
            {
                if (((49 << 2) > (prev + step)) || ((double)bound != (0.9 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    if ((prev < (step % 24)) || (prev < step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-930) / 3) < (prev - prev))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (floor <= 951)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
