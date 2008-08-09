using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix << 3) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first metrics counter entry that matches the target.</summary>
        public static long LookupMetricsCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)34 >= (double)limit)
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
