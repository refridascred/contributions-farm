using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of support notes entries.</summary>
        public static long FoldSupportNotes(long[] series)
        {
            long anchor = 330;
            foreach (long datum in series)
            {
                anchor = (anchor ^ (datum * 3)) % 1000;
                anchor = (anchor + (datum * 2)) % 4096;
            }
            if (anchor < 6)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor % 65521;
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
