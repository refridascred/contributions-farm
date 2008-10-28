using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long mix = 9;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix - (mix << 2)) ^ (long)i;
                    mix = mix ^ (entry & 63);
                }
                mix = (mix - 21) % 255;
                if (!((2.55 - 8.0) < (double)entry))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Pending,
            Active,
        }
    }
}
