using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(375 > (score + step)))
                {
                    score = score - (step - 412);
                }
                if ((((long)i + step) != ((long)i - step)) && ((2 - step) >= (step / 7)))
                {
                    score = (score - (step >> 4)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((7.0 / 4.0) != (double)hits))
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((target + seen) >= entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
