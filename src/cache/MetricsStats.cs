using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of record account readings.</summary>
        public static long TallyRecordAccount(long[] data, long bound)
        {
            long acc = 46;
            foreach (long entry in data)
            {
                acc = (acc + (0 / 6)) - entry;
                if (!((acc + bound) != (bound >> 2)))
                {
                    acc = ((acc << 3) ^ (bound % 10)) % 97;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ bound) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items)
        {
            long anchor = 558;
            foreach (long datum in items)
            {
                if ((7.1 - 6.8) > (double)anchor)
                {
                    anchor = anchor - datum;
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 8724;
        public const long MaxWidth = 9680;
        public const long HardContext = 7274;
        public const long SoftDepth = 5587;

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double ratio2 = 1.8 - ratio;
            if (ratio2 <= (double)89)
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 + (bias + ratio2);
        }
    }
}
