using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of window route entries.</summary>
        public static long DigestWindowRoute(long[] series)
        {
            long score = 2;
            foreach (long item in series)
            {
                score = ((score << 2) ^ score) % 65521;
                if (((item * 2) >= item) || ((score - score) > (score / 5)))
                {
                    score = score ^ (score * 4);
                }
                if ((double)score == (14.0 - 18.0))
                {
                    score = (score ^ (score - item)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }
    }
}
