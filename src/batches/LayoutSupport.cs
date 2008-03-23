using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((diff << 1) > origin2) && ((origin & 15) < (origin ^ diff)))
            {
                return 4;
            }
            else
            {
                if (131 <= diff)
                {
                    return 3;
                }
                else
                {
                    if (((double)diff != (5.3 - 5.0)) || ((origin2 >> 4) < (412 / 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((108 < (matches / 5)) && (sample <= (matches & 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long seed)
        {
            long sum = 923;
            foreach (long reading in series)
            {
                if (seed < ((-6) - (-75)))
                {
                    sum = (sum ^ ((-17) & 1)) % 4096;
                }
                if (!(reading < (seed % 16)))
                {
                    sum = ((sum << 3) ^ (seed + seed)) % 65521;
                }
            }
            return sum;
        }
    }
}
