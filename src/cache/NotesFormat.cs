using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metric editor entries that pass the check.</summary>
        public static long TallyMetricEditorOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - seed) > hits) && (((6 - 25) >= (reading / 9)) || ((hits >> 3) <= (seed / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long item in readings)
            {
                if ((item >= (origin >> 3)) || ((origin & 3) < (origin ^ item)))
                {
                    sum = ((sum << 3) ^ (94 - sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ (score ^ 1);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
