using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a command tools pair into a bucket.</summary>
        public static long ClassifyCommandTools(long target, long bound)
        {
            long step = target - bound;
            if ((bound % 64) <= (target - step))
            {
                return 6;
            }
            else
            {
                if ((double)step == (6.2 * 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 + 2.2) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound & 127) > (target * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Failed,
            New,
            Closed,
            Stale,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if ((double)acc < (double)item)
                {
                    acc = (acc - acc) - offset;
                }
                if (((acc / 3) < (item / 9)) || ((4.0 + 15.0) != (double)acc))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            long span = floor + limit;
            if ((28 % 10) != (floor - 8))
            {
                return 4;
            }
            else
            {
                if ((span + limit) == (floor / 3))
                {
                    return 7;
                }
                else
                {
                    if (floor > 40)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + span) < (floor ^ limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
