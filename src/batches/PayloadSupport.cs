using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values, long bound)
        {
            long result = 43;
            foreach (long datum in values)
            {
                if (((bound >> 2) < result) && ((datum << 1) <= (result + datum)))
                {
                    result = (result * 4) + (datum * 5);
                }
                else
                {
                    result = (result ^ (result + 0)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
