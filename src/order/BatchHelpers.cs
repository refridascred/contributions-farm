using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next contributi window value.</summary>
        public static double AdjustContributiWindow(double ratio, double span)
        {
            double gain = span;
            if (gain > (gain + ratio))
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (span - gain)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long TallyFilterProfileGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((floor << 1) >= sample)
                {
                    tally = tally + 1;
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
