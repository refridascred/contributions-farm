using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long CombineToolsGithubfarm(long[] data, long step)
        {
            long mix = 184;
            foreach (long sample in data)
            {
                mix = (((mix << 2) ^ (mix + sample)) % 255) + step;
            }
            if (mix < 801)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if (floor < (floor << 1))
            {
                return 5;
            }
            else
            {
                if ((floor < (bound % 24)) || ((bound - bound) <= (floor >> 1)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (bound + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((35 >> 1) != ((long)levels.Length - sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((sample * 2) >= anchor)
                {
                    anchor = (anchor * 2) + (sample * 5);
                }
            }
            return anchor;
        }
    }
}
