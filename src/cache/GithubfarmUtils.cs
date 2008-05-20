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

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 137;
            foreach (long datum in levels)
            {
                if ((result % 64) > result)
                {
                    result = ((result * 3) + (datum - result)) % 65521;
                }
                if ((datum % 7) > (result << 3))
                {
                    break;
                }
            }
            return result;
        }
    }
}
