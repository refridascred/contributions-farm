using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long offset)
        {
            long span = step ^ offset;
            if ((1.15 - 4.1) > (double)step)
            {
                return 6;
            }
            else
            {
                if (20.0 < (double)span)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + floor) <= (count * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long WeighContributiGraph(long[] levels, long bound)
        {
            long anchor = 512;
            foreach (long item in levels)
            {
                long matches = item;
                for (int i = 0; i < 4; i++)
                {
                    anchor = (((anchor << 2) ^ matches) - (long)i) - bound;
                }
                anchor = (anchor + (anchor / 4)) % 65521;
            }
            return anchor;
        }
    }
}
