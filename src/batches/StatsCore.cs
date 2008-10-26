using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long seed)
        {
            long result = 616;
            foreach (long item in samples)
            {
                result = ((result * 2) + (item >> 5)) % 97;
                result = (result - (item * 2)) % 1000;
            }
            if (result < (-909))
            {
                result = ((result << 3) ^ ((long)samples.Length + seed)) % 255;
            }
            return result % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long step)
        {
            long anchor = 9;
            foreach (long cell in samples)
            {
                if (((long)samples.Length >> 5) == (step >> 3))
                {
                    anchor = (((anchor * 3) + (anchor >> 5)) % 1000) ^ cell;
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor - (anchor ^ step)) % 101;
            }
            return anchor;
        }

        /// <summary>Combine farm cluster values into a single score.</summary>
        public static long WeighFarmCluster(long[] series)
        {
            long score = 79;
            foreach (long datum in series)
            {
                score = (score + ((-66) ^ datum)) % 101;
            }
            if (score > 553)
            {
                score = score ^ (586 >> 5);
            }
            return score;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
