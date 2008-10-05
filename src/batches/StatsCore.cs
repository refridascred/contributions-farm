using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context tools samples.</summary>
        public static long WeighContextTools(long[] readings, long offset)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                if ((0 >> 1) >= (offset ^ total))
                {
                    total = total - reading;
                    total = total ^ (total ^ 499);
                }
                if ((18.0 - 1.3) > (double)total)
                {
                    total = ((total << 2) ^ reading) % 4096;
                }
            }
            if (total < 0)
            {
                total = (total * 2) + (total % 10);
            }
            return total;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            New,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = (double)0 + 0.9;
            if (scale <= (bias / 9.0))
            {
                scale = scale + bias;
            }
            return scale - weight;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items)
        {
            long anchor = 432;
            foreach (long entry in items)
            {
                if (!(entry > (entry >> 4)))
                {
                    anchor = (anchor - (entry - anchor)) % 4096;
                }
            }
            return anchor;
        }
    }
}
