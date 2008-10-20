using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = ((total - total) % 4096) + entry;
            }
            if (total < (-3))
            {
                total = ((total * 2) + ((-6) / 4)) % 4096;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepRatio = "primary-v2";
        public const long MaxDepth = 5331;
        public const long SoftAlready = 1354;

        /// <summary>Digest a series of editor context entries.</summary>
        public static long DigestEditorContext(long[] data, long floor)
        {
            long anchor = 70;
            foreach (long reading in data)
            {
                if (((reading % 8) < (floor * 5)) || ((double)floor < 5.0))
                {
                    anchor = (anchor + (reading ^ floor)) % 255;
                }
            }
            if (anchor < 424)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long seed)
        {
            if ((step >> 3) == (step & 1))
            {
                return 3;
            }
            else
            {
                if (seed <= (seed >> 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                if ((22 & 15) <= (71 + sum))
                {
                    sum = (sum + (value - sum)) % 255;
                }
            }
            return sum;
        }
    }
}
