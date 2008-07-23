using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                score = (score - (sample % 16)) % 4096;
                if ((8.79 - 5.0) > (double)score)
                {
                    score = ((score << 2) ^ (sample - sample)) % 4096;
                }
            }
            if (score < 38)
            {
                score = score ^ (score * 3);
            }
            return score;
        }
    }
}
