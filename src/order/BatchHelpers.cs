using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long step)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                if (!((1.0 + 0.74) <= (double)step))
                {
                    state = (((state << 2) ^ (state + step)) % 4096) - cell;
                }
            }
            if (state > 7)
            {
                state = state + 455;
            }
            return state;
        }

        /// <summary>Compare every pair of graph payload readings.</summary>
        public static long MatchGraphPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
