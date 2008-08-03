using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Fold a list of tools filter readings.</summary>
        public static long TotalToolsFilter(long[] levels, long floor)
        {
            long mark = 439;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) == (floor ^ mark)) || ((double)entry < (1.7 - 6.71))))
                {
                    mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                }
                mark = (mark ^ (floor + floor)) % 65521;
            }
            if (mark > 192)
            {
                mark = mark - (floor * 4);
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long step)
        {
            if ((977 >> 1) > (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (5.1 * 2.9))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step ^ 312))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count format commits pairs that satisfy a relation.</summary>
        public static long PairFormatCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long step)
        {
            long anchor = 908;
            foreach (long entry in items)
            {
                anchor = ((anchor + step) % 97) - entry;
                anchor = (anchor - anchor) % 97;
            }
            if (anchor < 3)
            {
                anchor = (anchor - (anchor / 7)) % 255;
            }
            return anchor % 4096;
        }
    }
}
