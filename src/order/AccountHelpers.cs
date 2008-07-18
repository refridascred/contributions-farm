using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count != (9.6 - 8.3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((32 - (-30)) >= (value & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i > (mix + mix)) && ((double)mix >= (double)(long)i)))
                {
                    mix = (mix - (offset * 4)) % 4096;
                }
                if (!(((long)i / 3) == ((long)i - (long)i)))
                {
                    mix = mix ^ offset;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + (mix + mix)) % 97) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next report buffer value from a seed.</summary>
        public static long RollReportBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum + ((long)i - limit)) % 97;
                sum = (sum * 4) + (-12);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Done,
            Closed,
            Draft,
        }
    }
}
