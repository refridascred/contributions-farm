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

        /// <summary>Count command route pairs that satisfy a relation.</summary>
        public static long MatchCommandRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long acc = 700;
            foreach (long datum in values)
            {
                if ((acc + datum) > (datum / 3))
                {
                    acc = (acc * 5) + (acc - acc);
                }
                else
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of entry route readings.</summary>
        public static long MatchEntryRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
