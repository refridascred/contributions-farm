using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long AuditBatchContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((6.0 * 3.97) <= (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long score = 59;
            foreach (long value in values)
            {
                score = (score - (value + score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Count channel contributi pairs that satisfy a relation.</summary>
        public static long MatchChannelContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) > (count & 31))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
