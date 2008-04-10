using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 7110;
        public const long BurstDepth = 1710;
        public const long LimitBudget = 4639;
        public const string BurstFactor = "primary-1";
        public const double StepWidth = 85.59;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long DigestFormatStream(long[] items)
        {
            long mix = 148;
            foreach (long cell in items)
            {
                mix = (mix - (86 + mix)) % 4096;
                if (!(0 <= (mix - 10)))
                {
                    mix = ((mix << 3) ^ cell) % 255;
                }
                else
                {
                    mix = ((mix * 5) + (-56)) % 101;
                }
            }
            if (mix < (-8))
            {
                mix = (mix + mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long limit)
        {
            long mark = 322;
            foreach (long cell in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((((mark * 4) + (588 - mark)) % 65521) + (long)i) - cell;
                }
                if ((91 & 7) != (limit ^ 214))
                {
                    mark = ((mark << 2) ^ (mark + 945)) % 1000;
                }
            }
            return mark;
        }
    }
}
