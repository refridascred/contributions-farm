using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ datum) > (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter tools input into a small class.</summary>
        public static long ClassifyFilterTools(long bound, long step)
        {
            long span = bound + step;
            if (((237 + span) != (step - 155)) && ((double)6 <= (double)span))
            {
                return 8;
            }
            else
            {
                if (span < step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long mix = 15;
            foreach (long sample in items)
            {
                mix = (mix - 87) % 4096;
                if (((double)sample < (double)mix) || ((mix + mix) < sample))
                {
                    mix = mix ^ (sample % 3);
                }
            }
            if (mix < (-22))
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseFactor = 17.4;
        public const long WindowStream = 514;
        public const long IdleStream = 8522;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen / 3) != (62 / 5))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
