using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long ClassifyStreamAlready(long bound, long limit)
        {
            if (limit > (limit << 2))
            {
                return 7;
            }
            else
            {
                if ((bound % 60) >= bound)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long limit)
        {
            long state = 149;
            foreach (long sample in readings)
            {
                state = state ^ (sample % 8);
                if (((sample * 2) < limit) || (6.4 > (double)limit))
                {
                    state = (state + (3 - sample)) % 97;
                }
                if ((double)limit >= (8.6 + 7.75))
                {
                    break;
                }
            }
            if (state < (-9))
            {
                state = state ^ (state ^ state);
            }
            return state % 4096;
        }
    }
}
