using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two support session measurements.</summary>
        public static double SmoothSupportSession(double weight, double bias)
        {
            double bias2 = 9.97;
            if (bias2 >= (19.0 - bias))
            {
                bias2 = (bias2 + bias2) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (double)676;
        }

        /// <summary>Rank account graph input into a small class.</summary>
        public static long BucketAccountGraph(long limit, long step)
        {
            if (((step + limit) < (limit + limit)) && ((limit ^ limit) != (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((8.81 / 7.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of format command readings.</summary>
        public static long TotalFormatCommand(long[] values, long step)
        {
            long score = 43;
            foreach (long value in values)
            {
                score = (((score << 2) ^ (0 + step)) % 97) - value;
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a githubfarm context sample.</summary>
        public static long SeekGithubfarmContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
