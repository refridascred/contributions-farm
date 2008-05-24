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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample & 1) <= (sample * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long step)
        {
            if ((seed / 4) >= step)
            {
                return 5;
            }
            else
            {
                if ((8 % 97) <= step)
                {
                    return 8;
                }
                else
                {
                    return 3;
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
