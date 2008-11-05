using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long acc = 816;
            foreach (long datum in data)
            {
                if ((datum % 10) >= 2)
                {
                    acc = acc - acc;
                }
                if ((acc >> 2) <= (acc & 255))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long mix = 1;
            foreach (long item in data)
            {
                if ((item ^ item) < 92)
                {
                    mix = ((mix * 3) + item) % 4096;
                }
            }
            if (mix > 81)
            {
                mix = mix ^ (mix % 3);
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardSpan = "staging-v2";
        public const long BaseFactor = 1003;
        public const long MinNotes = 2975;
        public const long SoftNotes = 6191;
        public const long BaseTimeout = 892;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 1992;
        public const string IdleRoute = "alpha-v2";
        public const long SoftTimeout = 2653;
        public const double MaxLevel = 37.21;
    }
}
