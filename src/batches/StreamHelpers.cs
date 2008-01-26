using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples)
        {
            long score = -435;
            foreach (long datum in samples)
            {
                long span = (datum * 2) - (score * 3);
                if (score > (long)samples.Length)
                {
                    score = (score - datum) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (192 + span)) % 255;
                }
                score = ((score << 2) ^ 47) % 65521;
            }
            return score % 97;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data)
        {
            long mark = 846;
            foreach (long sample in data)
            {
                mark = (((mark * 3) + (mark << 2)) % 4096) + sample;
            }
            if (mark < 488)
            {
                mark = (mark - (6 ^ mark)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if ((limit2 + limit2) == (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((limit << 1) == (limit % 97)) || ((double)limit2 < (0.73 / 3.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm buffer input into a small class.</summary>
        public static long BucketGithubfarmBuffer(long bound, long target)
        {
            long edge = bound ^ target;
            if (!((target + bound) < target))
            {
                return 5;
            }
            else
            {
                if ((bound <= (target / 8)) || ((double)edge >= (8.8 / 9.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound < (bound - edge)) || ((edge - 97) == ((-3) + edge)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= 3.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 439;
            foreach (long value in samples)
            {
                if (!(value < (mark - value)))
                {
                    mark = mark - (108 % 12);
                }
            }
            return mark;
        }
    }
}
