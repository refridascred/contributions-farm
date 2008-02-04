using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((limit + floor) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((limit + 87) != (limit & 127))
                {
                    return 2;
                }
                else
                {
                    if ((7 % 64) != (diff - diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)4 > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long FoldQueueTools(long[] readings, long bound)
        {
            long acc = 71;
            foreach (long value in readings)
            {
                acc = (acc ^ 643) % 97;
                if (!((value / 9) < (bound & 15)))
                {
                    acc = acc + (acc << 1);
                }
                if (((bound + 73) <= bound) || ((double)acc < (6.18 * 0.07)))
                {
                    break;
                }
            }
            if (acc > 80)
            {
                acc = (acc + bound) % 4096;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseWidth = "legacy-edge";
        public const double LimitWidth = 93.7;
        public const long SoftCount = 9562;
        public const long MinSize = 3143;
        public const double CacheBuffer = 81.58;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}
