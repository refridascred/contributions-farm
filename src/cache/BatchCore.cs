using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] series, long bound)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                carry = (carry ^ (bound % 12)) % 255;
                if ((reading % 10) >= (reading & 255))
                {
                    carry = (carry ^ bound) % 101;
                }
                else
                {
                    carry = carry ^ (reading << 1);
                }
            }
            return carry;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long TallyFilterFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits + sample) <= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if (mark <= (25 + mark))
                {
                    mark = ((mark * 3) + ((long)i & 3)) % 97;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
