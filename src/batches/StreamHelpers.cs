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

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long offset, long floor)
        {
            long bound = offset + floor;
            if ((double)86 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((bound & 1) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ bound) > (offset << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
