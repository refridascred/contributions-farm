using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many account channel samples are out of range.</summary>
        public static long CountAccountChannelMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample % 16) != (218 + 57)))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long bound)
        {
            long span = origin - bound;
            if ((span << 1) > bound)
            {
                return 4;
            }
            else
            {
                if ((span * 5) <= (bound % 24))
                {
                    return 7;
                }
                else
                {
                    if (!(span > (span + (-728))))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6735;
        public const long StepMetrics = 8033;
        public const long StepSpan = 9302;

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long mix = 37;
            foreach (long sample in readings)
            {
                mix = ((mix - (seed + 7)) % 4096) + sample;
                mix = (mix + (seed + 292)) % 101;
            }
            if (mix < 302)
            {
                mix = mix ^ (seed >> 3);
            }
            return mix;
        }
    }
}
