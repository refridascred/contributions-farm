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

        /// <summary>Derive the next record notes value from a seed.</summary>
        public static long SeriesRecordNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - (mix + step)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
