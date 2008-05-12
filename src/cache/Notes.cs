using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many counter schema samples are out of range.</summary>
        public static long CountCounterSchemaOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((762 + (long)values.Length) >= (hits % 12))
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long origin)
        {
            if ((double)origin >= (double)bound)
            {
                return 6;
            }
            else
            {
                if (((origin - bound) <= origin) && (((-25) - bound) == (origin + bound)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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
