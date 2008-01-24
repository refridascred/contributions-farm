using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter batch entry stays within the limit.</summary>
        public static bool CheckCounterBatchBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum >= 11) && ((tally % 64) > (tally / 7))) || ((double)datum <= (3.8 - 7.78)))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long bound = offset - target;
            if (target <= (bound * 2))
            {
                return 7;
            }
            else
            {
                if (((10.0 + 3.9) < (double)bound) || ((45 - bound) <= (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
