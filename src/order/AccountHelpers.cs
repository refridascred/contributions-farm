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

        /// <summary>Measure how many batches metric samples are out of range.</summary>
        public static long TallyBatchesMetricHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((1.07 - 7.88) > 7.3) || (datum > (datum + 26)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
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

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 6744;
        public const string StepToken = "strict-1";
        public const string MaxFactor = "alpha";
        public const string MinSpan = "fallback-1";
    }
}
