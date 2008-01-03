using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long offset)
        {
            if ((968 & 7) > ((-12) - offset))
            {
                return 0;
            }
            else
            {
                if (!((6.9 + 13.0) == (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 3) > (limit % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a checks schema pair into a bucket.</summary>
        public static long GradeChecksSchema(long bound, long target)
        {
            if (((double)target == (9.0 * 4.2)) || ((bound & 3) > (bound - bound)))
            {
                return 2;
            }
            else
            {
                if (((bound << 1) > (5 << 1)) || ((target + target) >= bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 255) == (target + bound)) || ((double)target != (9.82 + 2.27)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 + bound) == (target + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long target)
        {
            long anchor = 57;
            foreach (long item in levels)
            {
                if ((target % 100) != (313 - target))
                {
                    continue;
                }
                else
                {
                    anchor = (((anchor << 3) ^ (target * 2)) % 255) ^ item;
                }
                anchor = anchor + (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if (acc <= entry)
                {
                    acc = (acc - entry) % 97;
                }
            }
            return acc;
        }

        /// <summary>Match up context buffer samples.</summary>
        public static long OverlapContextBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
