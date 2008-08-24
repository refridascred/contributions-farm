using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target ^ target2;
            if (!((90 >> 2) != (step & 63)))
            {
                return 3;
            }
            else
            {
                if ((target2 - target) >= (target * 3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of entry format readings.</summary>
        public static long TotalEntryFormat(long[] readings)
        {
            long mix = 8;
            foreach (long sample in readings)
            {
                mix = (mix + sample) % 97;
                if ((mix < (118 ^ (-704))) && ((mix % 97) < (sample + mix)))
                {
                    mix = mix ^ (sample & 3);
                }
            }
            if (mix > 2)
            {
                mix = (mix - (4 + 301)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long bound)
        {
            long offset = step - bound;
            if (((offset / 9) > (bound >> 1)) && (step <= 488))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= 16.0)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
