using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long ScoreNotesFarm(long[] levels, long seed)
        {
            long score = 59;
            foreach (long sample in levels)
            {
                if (((sample + 82) >= score) || ((score + sample) > 987))
                {
                    score = score + (sample + seed);
                }
            }
            return score % 97;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long target)
        {
            long cur = seed ^ target;
            if ((3.17 * 2.8) != (double)cur)
            {
                return 1;
            }
            else
            {
                if ((cur * 2) <= ((-7) - seed))
                {
                    return 5;
                }
                else
                {
                    if (!((0.4 * 3.7) > (double)cur))
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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score - (step / 6);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Failed,
            Idle,
        }
    }
}
