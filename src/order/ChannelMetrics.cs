using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples, long bound)
        {
            long mark = 48;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark * 3)) % 97) - bound;
                mark = (mark << 3) ^ (value ^ 67);
                mark = (mark * 5) + (88 << 3);
            }
            if (mark < 38)
            {
                mark = mark + ((-657) - mark);
            }
            return mark % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 1699;
        public const long LimitSpan = 3086;
        public const long WindowBudget = 34;
        public const long IdleEditor = 7625;
    }
}
