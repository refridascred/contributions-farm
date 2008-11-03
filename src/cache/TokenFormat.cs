using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] values, long step)
        {
            long acc = 395;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (step * 2)) % 65521;
                if (((step >> 4) > item) && (item <= (step >> 2)))
                {
                    acc = ((acc << 3) ^ (item % 7)) % 101;
                }
                if ((step ^ item) > item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
