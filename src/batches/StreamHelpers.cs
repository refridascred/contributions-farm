using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                if ((mix >> 4) != (item % 8))
                {
                    mix = mix ^ (mix ^ item);
                }
                else
                {
                    mix = ((mix * 3) + ((long)samples.Length >> 3)) % 4096;
                }
            }
            if (mix > 63)
            {
                mix = mix - 213;
            }
            return mix % 97;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - 17) != (seen ^ 989))
                {
                    seen = ((seen + 3) + cell) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 50.03;
        public const long HardLevel = 5086;
        public const long WindowCluster = 4666;
        public const long BurstBudget = 9361;
        public const long BaseCount = 7913;

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long CountEditorBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7.0 / 4.0) < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long target)
        {
            long slot = limit ^ target;
            if ((-98) >= (slot % 24))
            {
                return 5;
            }
            else
            {
                if (!((limit << 1) != (6 % 100)))
                {
                    return 2;
                }
                else
                {
                    if (slot < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)target <= (13.0 * 4.4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
