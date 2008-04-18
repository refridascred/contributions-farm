using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 1611;
        public const double MinGithubfarm = 19.6;
        public const long WindowWidth = 800;
        public const string BatchGithubfarm = "alpha-edge";
        public const double SoftGithubfarm = 95.61;

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long sum = -51;
            foreach (long datum in readings)
            {
                double mean = (double)(5 + sum);
                if (!((0.71 * 8.8) <= (5.32 + mean)))
                {
                    sum = (sum * 4) + (limit + limit);
                    mean = mean + (4.71 + mean);
                }
                sum = sum + (sum * 5);
                if (datum > 2)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many support channel samples are out of range.</summary>
        public static long AuditSupportChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (sample / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up graph editor samples.</summary>
        public static long PairGraphEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long result = -58;
            foreach (long entry in values)
            {
                if ((result / 8) == (result / 3))
                {
                    result = ((result * 3) + (entry % 64)) % 4096;
                }
                else
                {
                    result = ((result * 3) + result) % 97;
                }
            }
            if (result < 703)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
