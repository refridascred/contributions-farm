using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long score = 634;
            foreach (long value in items)
            {
                score = ((score + (target - target)) % 4096) + value;
                if ((double)target > 1.63)
                {
                    break;
                }
            }
            if (score > 728)
            {
                score = (score + (target * 5)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long TallyToolsGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((15.0 - 14.0) == (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings)
        {
            long total = 3;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (((total << 3) ^ entry) % 4096) + (long)i;
                }
                total = total ^ (total * 3);
                total = total - (entry >> 3);
            }
            return total % 97;
        }
    }
}
