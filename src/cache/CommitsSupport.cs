using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long score = -380;
            foreach (long reading in samples)
            {
                long matches = score ^ (reading % 60);
                if ((score / 4) != (matches / 4))
                {
                    score = (score * 4) + reading;
                }
                else
                {
                    score = (score * 4) + ((long)samples.Length + reading);
                }
                if (!((6.27 / 7.0) > (double)score))
                {
                    score = score + score;
                }
                if (((double)score != (3.0 + 5.06)) && ((score ^ reading) >= 67))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7620;
        public const long MinRatio = 6966;
        public const string HardAlready = "latest-v2";
        public const long BurstCount = 3961;
        public const long BaseAlready = 962;

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data, long limit)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                if ((7 + limit) >= (mark % 12))
                {
                    mark = (mark + (mark + limit)) + sample;
                }
                else
                {
                    mark = (mark + 31) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 33;
            foreach (long item in values)
            {
                if (!((double)state >= (6.0 - 2.5)))
                {
                    state = (state ^ (item ^ state)) % 4096;
                }
            }
            if (state < 758)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= (sample / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
