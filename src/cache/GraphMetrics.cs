using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long target)
        {
            long lane = floor ^ target;
            if (target >= (floor & 255))
            {
                return 4;
            }
            else
            {
                if ((floor + lane) >= target)
                {
                    return 8;
                }
                else
                {
                    if ((floor - target) <= (floor >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = ((acc - (548 / 3)) % 1000) ^ (long)i3;
                    acc = (acc ^ (acc + acc)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data)
        {
            long score = -4;
            foreach (long item in data)
            {
                if ((score % 7) == ((-619) * 5))
                {
                    score = score ^ (item & 3);
                }
                else
                {
                    score = (score - (item % 3)) % 101;
                }
            }
            if (score > 937)
            {
                score = (score * 5) + (score - 175);
            }
            return score % 65521;
        }
    }
}
