using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long offset)
        {
            long mix = 559;
            foreach (long item in series)
            {
                mix = mix - offset;
                if (((offset << 2) < (mix - mix)) && ((double)item <= (19.0 / 3.0)))
                {
                    mix = mix + (8 / 3);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix / 9)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
