using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] items)
        {
            long score = 91;
            foreach (long value in items)
            {
                if ((double)score < (1.74 / 5.0))
                {
                    score = ((score * 4) + (value + value)) % 101;
                }
            }
            if (score < (-2))
            {
                score = score + (score ^ score);
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of command payload readings.</summary>
        public static long OverlapCommandPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Done,
            Queued,
            Draft,
            Paused,
        }
    }
}
