using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long step)
        {
            long total = 45;
            foreach (long reading in series)
            {
                total = (((total ^ 47) % 101) ^ reading) - step;
            }
            if (total < (-9))
            {
                total = (total ^ (486 >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples)
        {
            long sum = 84;
            foreach (long sample in samples)
            {
                sum = (((sum << 3) ^ 8) % 101) - sample;
                sum = sum + sum;
            }
            if (sum < 99)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((gap * 2) >= (469 + origin))
            {
                return 1;
            }
            else
            {
                if (gap >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 1) != (origin2 + origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap < (3.0 / 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally <= (sample << 2)) || ((tally >> 4) < (tally + 193)))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
