using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate context farm samples.</summary>
        public static long CombineContextFarm(long[] values)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((mix ^ sample) == (3 & 1))
                {
                    mix = (mix + ((-885) + sample)) % 1000;
                }
            }
            if (mix > 975)
            {
                mix = (mix << 2) ^ 645;
            }
            return mix % 97;
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
