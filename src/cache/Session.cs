using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((bound / 2) < (long)values.Length)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long WeighCommitsNotes(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                if ((datum - mix) == (floor + floor))
                {
                    mix = ((mix * 5) + floor) % 255;
                }
            }
            if (mix > 88)
            {
                mix = ((mix * 3) + (79 ^ mix)) % 255;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 1956;
        public const long HardGithubfarm = 3713;
        public const double BurstInterval = 62.26;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long step)
        {
            if ((floor - floor) <= (step / 2))
            {
                return 2;
            }
            else
            {
                if ((step + floor) < (floor << 1))
                {
                    return 1;
                }
                else
                {
                    if ((step >= (741 * 4)) || ((step % 7) > (step & 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
