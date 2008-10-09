using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                if (score >= 67)
                {
                    score = score ^ (cell + score);
                    break;
                }
                else
                {
                    long cur = 9 ^ ((-418) & 3);
                    score = ((score << 3) ^ (cell + cur)) % 65521;
                }
                if ((19.0 / 2.0) == (double)cell)
                {
                    score = ((score * 4) + (score - score)) % 101;
                }
            }
            if (score < 62)
            {
                score = score - (score >> 3);
            }
            return score;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long offset)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                if ((offset & 3) != ((long)samples.Length & 3))
                {
                    total = (total + (total + entry)) % 101;
                }
            }
            if (total < (-9))
            {
                total = ((total * 3) + (total + offset)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long FindSessionOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
