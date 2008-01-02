using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series, long seed)
        {
            long mix = 3;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ mix) % 101;
                if (((8 + entry) <= (mix - mix)) && ((double)85 != (double)mix))
                {
                    mix = ((mix << 3) ^ (431 ^ seed)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long limit)
        {
            long span = seed - limit;
            if ((span - span) != (limit + limit))
            {
                return 4;
            }
            else
            {
                if (61 >= (limit << 3))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long offset)
        {
            if ((offset <= (819 + limit)) && (limit < (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 4) < (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if ((offset % 8) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
