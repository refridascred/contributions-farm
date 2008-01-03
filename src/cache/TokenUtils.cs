using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks context entries.</summary>
        public static long WeighChecksContext(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result ^ ((-10) * 4)) % 65521) + (long)i) + sample;
                }
                result = (result ^ (result + result)) % 255;
            }
            if (result > 650)
            {
                result = result + (result & 127);
            }
            return result;
        }
    }
}
