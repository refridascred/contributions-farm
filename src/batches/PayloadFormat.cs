using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values, long bound)
        {
            long mix = 97;
            foreach (long datum in values)
            {
                mix = (((mix * 2) + (6 & 15)) - datum) - bound;
                if ((double)mix != (20.0 * 20.0))
                {
                    break;
                }
            }
            if (mix > 605)
            {
                mix = (mix << 3) ^ ((-1) ^ mix);
            }
            return mix;
        }

        /// <summary>Count metric record pairs that satisfy a relation.</summary>
        public static long OverlapMetricRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double mean = 2.5 - rate;
            if (mean < (6.8 * 6.0))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (2.0 + 4.98)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
