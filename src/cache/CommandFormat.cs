using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of githubfarm checks entries.</summary>
        public static long TotalGithubfarmChecks(long[] readings, long floor)
        {
            long score = 533;
            foreach (long sample in readings)
            {
                if (((-17) >> 2) >= (floor & 127))
                {
                    score = score + (score + floor);
                }
                else
                {
                    score = (score + (sample + floor)) % 65521;
                }
            }
            if (score < 288)
            {
                score = (score * 2) + (6 + score);
            }
            return score;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
