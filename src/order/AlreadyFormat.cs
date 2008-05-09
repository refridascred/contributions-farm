using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit graph editor readings against a rule.</summary>
        public static long MeasureGraphEditorOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)3 >= (double)count)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i ^ score) > origin)
                {
                    score = ((score << 3) ^ (origin + origin)) % 101;
                    score = score - (506 ^ origin);
                    break;
                }
                else
                {
                    score = (score - (score >> 1)) % 1000;
                }
                if ((origin % 100) > (score ^ 234))
                {
                    score = (score + (origin & 127)) % 255;
                }
                if ((origin < 706) && ((origin + 672) < (score * 2)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 671;
            foreach (long cell in items)
            {
                if (9.0 < (double)cell)
                {
                    score = score - (score + cell);
                }
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long sum = 785;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length < (5.0 + 6.57))
                {
                    sum = (sum << 2) ^ value;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
