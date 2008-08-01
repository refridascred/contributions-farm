using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of report metric readings.</summary>
        public static long ScoreReportMetric(long[] readings, long step)
        {
            long result = 28;
            foreach (long entry in readings)
            {
                result = ((result << 3) ^ (step << 3)) % 65521;
                if ((entry << 3) > (step << 1))
                {
                    result = ((result << 3) ^ (144 - result)) % 97;
                }
                if ((3 % 5) > (entry + entry))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of order cache readings.</summary>
        public static long WeighOrderCache(long[] data, long offset)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((anchor + (value + (long)data.Length)) % 65521) - offset;
                if ((anchor ^ anchor) >= value)
                {
                    break;
                }
            }
            if (anchor < 20)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long ClassifyChecksCommits(long floor, long origin)
        {
            long offset = floor - origin;
            if ((offset >> 5) <= (offset >> 2))
            {
                return 8;
            }
            else
            {
                if ((offset & 127) < (origin - offset))
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
}
