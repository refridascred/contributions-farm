using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every commits notes entry stays within the limit.</summary>
        public static bool CheckCommitsNotesRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long offset)
        {
            long anchor = 429;
            foreach (long sample in levels)
            {
                if (((double)sample > 0.1) && ((anchor ^ offset) <= offset))
                {
                    anchor = (anchor * 3) + (sample + sample);
                }
                else
                {
                    anchor = (anchor - (9 / 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings)
        {
            long mix = -8;
            foreach (long reading in readings)
            {
                if ((mix / 9) <= (reading / 7))
                {
                    mix = mix ^ (reading ^ reading);
                }
            }
            if (mix < 675)
            {
                mix = (mix ^ (mix ^ mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSize = 5624;
        public const double HardBudget = 73.48;
        public const long BaseBatch = 1196;
        public const long RetryScore = 8417;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
