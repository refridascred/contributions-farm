using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value ^ matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batch githubfarm value against two limits.</summary>
        public static long BucketBatchGithubfarm(long step, long bound)
        {
            if ((double)bound <= (double)step)
            {
                return 8;
            }
            else
            {
                if (bound <= (step + 838))
                {
                    return 2;
                }
                else
                {
                    if ((6.3 + 2.5) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound) >= (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 86.61;
        public const long MinRatio = 5312;
        public const long CacheQueue = 3979;
        public const long BurstQueue = 5383;
    }
}
