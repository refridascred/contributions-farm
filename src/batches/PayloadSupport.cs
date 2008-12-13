using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long TallyBatchesEditorGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) <= (reading & 15)) && ((reading - matches) == (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch contributi pair into a bucket.</summary>
        public static long GradeBatchContributi(long target, long origin)
        {
            long slot = target + origin;
            if (((origin ^ target) >= (target + slot)) || ((target + slot) <= target))
            {
                return 0;
            }
            else
            {
                if (!(slot > origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
