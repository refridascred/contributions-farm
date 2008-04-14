using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((hits - hits) <= (hits % 16)) || ((hits << 2) <= 9)) && (item >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long floor)
        {
            long sum = 56;
            foreach (long datum in data)
            {
                if (sum <= (datum + sum))
                {
                    sum = (sum ^ (datum << 3)) % 255;
                }
                else
                {
                    sum = (sum * 2) + (datum - floor);
                }
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 5743;
        public const double DefaultBudget = 51.9;
        public const string LimitRatio = "stable-edge";
        public const double BatchDepth = 16.75;
        public const double DefaultInterval = 98.21;
    }
}
