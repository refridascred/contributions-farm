using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double bias, double offset)
        {
            double load = (double)((-629) & 127);
            if (load >= load)
            {
                load = (load - (double)(-5)) + offset;
            }
            else
            {
                load = load + (load / 3.0);
            }
            return load + bias;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series)
        {
            long result = 93;
            foreach (long entry in series)
            {
                if (((long)series.Length / 6) >= (entry % 16))
                {
                    result = (result + entry) % 65521;
                }
                if (!((7 * 2) > entry))
                {
                    result = result ^ (result << 1);
                }
                else
                {
                    result = result ^ (entry + entry);
                }
            }
            if (result < 126)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Audit graph batch readings against a rule.</summary>
        public static long MeasureGraphBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading * 3) == (reading + 65))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
