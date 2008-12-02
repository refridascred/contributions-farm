using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target < (2.0 / 5.0))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long target2)
        {
            long prev = target ^ target2;
            if ((prev & 15) >= (target - 5))
            {
                return 3;
            }
            else
            {
                if ((prev / 8) <= target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up checks profile samples.</summary>
        public static long OverlapChecksProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 4;
            foreach (long entry in readings)
            {
                if (!((553 + carry) >= 436))
                {
                    carry = ((carry ^ (9 / 4)) % 65521) + entry;
                }
                else
                {
                    carry = ((carry * 3) + 267) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = ((carry * 2) + (carry - carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Project the next cache githubfarm value.</summary>
        public static double BlendCacheGithubfarm(double gain, double floor)
        {
            double weight = (double)(407 * 2);
            return ((weight + (double)658) + gain) + floor;
        }

        /// <summary>Iterate the route graph series from a seed.</summary>
        public static long RollRouteGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc * 5)) % 1000;
                if ((seed + 3) < (acc + seed))
                {
                    acc = (acc * 3) + seed;
                    acc = (acc - ((long)i + 167)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
