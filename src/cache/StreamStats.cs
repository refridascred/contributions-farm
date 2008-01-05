using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double bias = (weight - offset) + (double)91;
            if (bias < (bias * 2.4))
            {
                bias = bias - (weight * 8.05);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + 7.62) + (double)(long)i;
            }
            return bias - (6.3 + offset);
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels, long step)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                if ((604 & 31) < (entry + entry))
                {
                    mark = mark + 7;
                    mark = mark - entry;
                }
                mark = ((mark << 3) ^ 3) % 4096;
            }
            if (mark > 75)
            {
                mark = (mark - (step / 6)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchWidth = 7.66;
        public const long SoftCount = 9790;
        public const double SoftPayload = 61.0;
    }
}
