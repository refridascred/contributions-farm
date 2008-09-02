using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            if (((double)bound == (double)1) || ((offset << 3) < (-20)))
            {
                return 7;
            }
            else
            {
                if (offset <= (7 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up tools batch samples.</summary>
        public static long OverlapToolsBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
