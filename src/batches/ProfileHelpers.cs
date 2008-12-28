using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples, long step)
        {
            long score = 782;
            foreach (long item in samples)
            {
                if ((item + score) > (score >> 2))
                {
                    score = (score + (step % 5)) % 1000;
                }
                score = (score << 2) ^ (step + item);
            }
            return score % 4096;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batch buffer input into a small class.</summary>
        public static long GradeBatchBuffer(long bound, long limit)
        {
            long lane = bound ^ limit;
            if (!((double)lane <= (0.72 + 2.0)))
            {
                return 3;
            }
            else
            {
                if ((limit + lane) >= 2)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count githubfarm commits pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
