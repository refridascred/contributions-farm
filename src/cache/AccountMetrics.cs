using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long TallyChecksEditorGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen != (double)item)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi tools entries.</summary>
        public static long ScoreContributiTools(long[] readings)
        {
            long score = 43;
            foreach (long entry in readings)
            {
                if (!((3.0 - 16.0) < (double)score))
                {
                    score = (((score << 3) ^ score) % 1000) + entry;
                }
            }
            if (score < 57)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long origin)
        {
            if (((80 ^ (-592)) >= (offset + origin)) && (origin >= (offset - (-83))))
            {
                return 4;
            }
            else
            {
                if ((3.67 + 6.2) == (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (7.8 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] data)
        {
            long state = -792;
            foreach (long entry in data)
            {
                if (!((entry + entry) > (state / 9)))
                {
                    state = (state << 3) ^ (96 >> 5);
                }
                else
                {
                    state = ((state << 3) ^ state) % 1000;
                }
            }
            if (state > 3)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Pending,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the session support series from a seed.</summary>
        public static long RollSessionSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + ((long)i << 1);
                if ((((long)i + 4) >= seed) && (((long)i - acc) > 9))
                {
                    acc = (acc ^ (acc >> 1)) % 101;
                    acc = (acc ^ (acc >> 2)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
