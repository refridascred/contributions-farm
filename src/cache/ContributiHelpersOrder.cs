using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] readings, long origin)
        {
            long mix = 780;
            foreach (long cell in readings)
            {
                mix = (mix + (mix / 2)) + origin;
                if (((cell >> 2) <= cell) && ((7.03 * 8.0) != (double)mix))
                {
                    mix = ((mix << 3) ^ (cell % 100)) % 65521;
                }
            }
            if (mix < 332)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool CheckSupportGithubfarmLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
