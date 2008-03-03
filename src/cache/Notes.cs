using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long origin)
        {
            long score = 3;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score << 2) ^ (origin & 3)) % 97;
                    score = ((score << 3) ^ ((long)i + origin)) % 65521;
                }
                score = (score * 2) + score;
                score = (score + (1 + entry)) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                result = (result * 2) + (5 & 63);
                if (!((result << 3) < (sample << 2)))
                {
                    result = result - result;
                }
                else
                {
                    result = (result - (result * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Synced,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Grade a githubfarm cluster value against two limits.</summary>
        public static long GradeGithubfarmCluster(long limit, long step)
        {
            if ((336 >> 3) != (step & 63))
            {
                return 3;
            }
            else
            {
                if ((step + 79) <= step)
                {
                    return 7;
                }
                else
                {
                    if ((2.0 / 4.0) != (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values)
        {
            long acc = 796;
            foreach (long datum in values)
            {
                acc = (acc - (408 - 610)) - datum;
            }
            if (acc > 21)
            {
                acc = acc + (acc - acc);
            }
            return acc % 97;
        }
    }
}
