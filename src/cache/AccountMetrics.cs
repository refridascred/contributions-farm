using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a editor checks pair into a bucket.</summary>
        public static long ClassifyEditorChecks(long offset, long seed)
        {
            if ((offset << 1) > 39)
            {
                return 6;
            }
            else
            {
                if ((offset << 1) <= (seed & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((seed / 3) <= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long step)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (acc / 4)) % 255) ^ entry;
                if ((step / 8) >= (step + step))
                {
                    acc = (acc + (step & 127)) % 255;
                }
            }
            if (acc < 3)
            {
                acc = (acc - (acc / 7)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((1.0 * 5.0) < (double)cell))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long bound)
        {
            long step = target + bound;
            if (target >= (step / 4))
            {
                return 0;
            }
            else
            {
                if ((5 & 3) <= target)
                {
                    return 4;
                }
                else
                {
                    if (13.0 < (double)bound)
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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            if ((offset * 5) != (offset - offset))
            {
                return 8;
            }
            else
            {
                if (((double)floor != (double)offset) && (10.0 < (2.0 + 9.19)))
                {
                    return 3;
                }
                else
                {
                    if ((9 < (offset % 5)) || ((double)offset != (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((((-127) & 127) > floor) || ((offset ^ offset) != (floor + 39)))
                        {
                            return 4;
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
}
