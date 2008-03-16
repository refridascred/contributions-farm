using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long acc = -5;
            foreach (long reading in data)
            {
                acc = acc + (reading - reading);
            }
            return acc;
        }

        /// <summary>Audit session cache readings against a rule.</summary>
        public static long MeasureSessionCacheGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length > (seed & 1))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score + 6) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
