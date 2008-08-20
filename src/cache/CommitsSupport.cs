using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series)
        {
            long mix = 590;
            foreach (long sample in series)
            {
                if ((mix >> 5) != (sample ^ sample))
                {
                    mix = ((mix * 4) + sample) % 4096;
                }
                else
                {
                    mix = mix ^ (mix - 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Match up account metrics samples.</summary>
        public static long PairAccountMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 2525;
        public const long WindowTimeout = 1121;
        public const string BaseCount = "latest-edge";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Paused,
            New,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 8251;
        public const long IdleQueue = 8011;
        public const long MinFactor = 5153;
        public const long DefaultBudget = 3172;
        public const long HardQueue = 1661;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((18.0 + 3.7) <= (double)matches) && ((matches & 127) != ((-9) & 1)))
                {
                    matches = ((matches + 2) - datum) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
