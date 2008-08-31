using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long score = -665;
            foreach (long reading in levels)
            {
                if ((reading & 127) <= (score + score))
                {
                    score = (score * 4) + (reading << 3);
                }
                else
                {
                    score = (score ^ reading) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine commits githubfarm values into a single score.</summary>
        public static long TotalCommitsGithubfarm(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                long prev = cell;
                anchor = (anchor * 2) + (prev - 211);
                if (cell <= (cell - anchor))
                {
                    anchor = (anchor << 3) ^ (cell / 8);
                }
            }
            return anchor;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings)
        {
            long mix = 10;
            foreach (long cell in readings)
            {
                if (!((mix + 69) == (mix & 7)))
                {
                    mix = ((mix * 4) + (cell % 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
