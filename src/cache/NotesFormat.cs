using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double weight = (double)(-544) / 8.0;
            if (weight > span)
            {
                weight = (weight - (weight / 9.0)) - scale;
            }
            return weight - (weight / 4.0);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((-244) >= (hits * 2)) || (((hits - hits) < hits) && (hits < (1 - (-9)))))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
