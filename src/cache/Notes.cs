using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell > (520 << 3)) || (cell >= ((-626) + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry - (884 + 6)) % 255) + (long)i2;
                }
                long seen = ((long)i ^ (long)i) / 3;
                carry = ((carry << 3) ^ (seen - seen)) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit metric context readings against a rule.</summary>
        public static long AuditMetricContextGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry > bound) && (bound > (entry ^ matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
