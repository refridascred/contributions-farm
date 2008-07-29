using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "local";
        public const long BaseBuffer = 493;
        public const long RetryBuffer = 2185;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long mix = 358;
            foreach (long item in data)
            {
                mix = ((mix ^ (origin >> 1)) % 97) ^ item;
            }
            if (mix < 38)
            {
                mix = mix + (long)data.Length;
            }
            return mix;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
