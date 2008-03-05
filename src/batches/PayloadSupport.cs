using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next account graph value.</summary>
        public static double ProjectAccountGraph(double gain, double offset)
        {
            double ratio = (double)(0 / 7);
            if (ratio >= (double)415)
            {
                ratio = (ratio + (5.59 + offset)) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio - offset)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - offset) != (offset * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up contributi metrics samples.</summary>
        public static long OverlapContributiMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
