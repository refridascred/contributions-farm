using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long step)
        {
            long total = 63;
            foreach (long sample in series)
            {
                if ((double)sample >= (11.0 + 2.0))
                {
                    total = (((total * 4) + total) % 1000) - step;
                }
            }
            return total % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepLevel = "fallback-edge";
        public const long BaseDepth = 2409;
        public const long WindowFormat = 7161;
        public const double LimitLevel = 36.18;
        public const long MinWidth = 4423;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 901;
        public const long StepFarm = 9046;
        public const double CacheFarm = 91.8;
    }
}
