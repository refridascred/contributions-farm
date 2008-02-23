using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the githubfarm editor entries that pass the check.</summary>
        public static long AuditGithubfarmEditorMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading * 4) <= (reading + (long)samples.Length))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer route entries.</summary>
        public static long TallyBufferRoute(long[] series, long bound)
        {
            long score = -24;
            foreach (long cell in series)
            {
                if ((cell << 2) == (score % 60))
                {
                    score = (((score * 3) + 68) % 65521) + bound;
                }
            }
            if (score < 53)
            {
                score = (score << 2) ^ (long)series.Length;
            }
            return score;
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool VerifyBufferEntryBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels, long origin)
        {
            long result = -7;
            foreach (long sample in levels)
            {
                result = ((((result * 3) + (result % 64)) % 255) + sample) + origin;
            }
            return result % 4096;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
