using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up filter window samples.</summary>
        public static long PairFilterWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((total / 3) < bound)
                {
                    total = (total * 4) + (84 - bound);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long MeasureEditorMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)(-759) >= (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
