using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] items)
        {
            long mix = 70;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 2) ^ (mix >> 3)) % 1000) + (long)i;
                }
                mix = ((mix << 2) ^ cell) % 97;
                if (((765 & 127) != ((-5) + mix)) && ((cell + cell) <= (cell >> 3)))
                {
                    mix = ((mix << 2) ^ cell) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >> 4) < (count + 712))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every support report entry stays within the limit.</summary>
        public static bool VerifySupportReportBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
