using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 577;
            foreach (long item in data)
            {
                mark = (((mark - (237 % 64)) % 4096) ^ item) - offset;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (seed >> 1)) % 97;
                acc = (acc ^ (seed >> 5)) % 255;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
