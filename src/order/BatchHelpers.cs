using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a tools farm figure with a bias.</summary>
        public static double ScaleToolsFarm(double weight, double offset)
        {
            double scale = offset + weight;
            if (scale < (double)449)
            {
                scale = scale + (4.5 - offset);
            }
            return scale + (double)(-59);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9.45 <= (double)matches) || !(90 >= matches))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 8013;
        public const long MinChannel = 9035;
        public const long BatchChannel = 9416;
        public const long StepRatio = 6249;
    }
}
