using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((limit ^ value) != (limit >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long bound)
        {
            long mix = 1;
            foreach (long cell in data)
            {
                mix = ((mix * 2) + (bound ^ cell)) % 1000;
            }
            if (mix > 212)
            {
                mix = mix - (89 & 127);
            }
            return mix % 1000;
        }

        /// <summary>Audit profile farm readings against a rule.</summary>
        public static long TallyProfileFarmOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (5.5 - 6.0)) || (((long)samples.Length ^ limit) > (limit % 10)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
