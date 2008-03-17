using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session format samples.</summary>
        public static long OverlapSessionFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long limit)
        {
            long bound = origin ^ limit;
            if ((origin + 71) == (origin - 54))
            {
                return 7;
            }
            else
            {
                if ((1.2 - 18.0) >= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
