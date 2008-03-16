using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream context readings against a rule.</summary>
        public static long AuditStreamContextHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count == (0.2 * 8.2))
                {
                    count = ((count + 1) - sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((double)tally == (0.6 / 8.0)) && ((tally << 2) <= (datum + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm command readings.</summary>
        public static long PairGithubfarmCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
