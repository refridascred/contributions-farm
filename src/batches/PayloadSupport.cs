using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of support layout readings.</summary>
        public static long OverlapSupportLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings)
        {
            long score = 774;
            foreach (long sample in readings)
            {
                if (sample <= (score - sample))
                {
                    score = score + 8;
                }
            }
            if (score > (-71))
            {
                score = (score - score) % 101;
            }
            return score % 1000;
        }
    }
}
