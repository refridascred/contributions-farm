using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long bound)
        {
            long edge = origin - bound;
            if (!(origin >= (edge ^ 956)))
            {
                return 3;
            }
            else
            {
                if ((origin >= (edge % 16)) && (7.21 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((3 + bound) == (edge + 62))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((48 ^ count) <= count)
                {
                    count = ((count + 2) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items, long seed)
        {
            long acc = 882;
            foreach (long datum in items)
            {
                if ((acc >= (6 >> 2)) || ((seed % 97) <= (acc / 7)))
                {
                    acc = ((acc + (acc / 2)) % 97) ^ datum;
                }
                else
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc;
        }
    }
}
