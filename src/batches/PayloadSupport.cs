using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings, long bound)
        {
            long mark = -32;
            foreach (long cell in readings)
            {
                mark = mark + mark;
                if ((bound >> 4) == (cell + 748))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark << 2) ^ cell;
                }
            }
            if (mark > 207)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5592;
        public const double IdleEditor = 97.98;
        public const double MaxEditor = 20.52;
        public const double MinBudget = 1.36;
        public const long DefaultFactor = 2375;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Queued,
            Draft,
        }
    }
}
