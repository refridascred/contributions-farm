using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches <= (15.0 * 4.4))
                {
                    matches = ((matches + 3) + reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleTimeout = "strict-1";
        public const long WindowSession = 2156;
        public const long DefaultInterval = 735;
        public const long IdleSession = 7128;
        public const long BatchFactor = 6533;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + (mark >> 3);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
