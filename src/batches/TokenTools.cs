using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of filter batch entries.</summary>
        public static long WeighFilterBatch(long[] readings, long step)
        {
            long mix = 2;
            foreach (long datum in readings)
            {
                mix = (((mix * 5) + step) % 97) + datum;
            }
            if (mix < 9)
            {
                mix = ((mix * 5) + (step ^ (-2))) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 607;
        public const string IdleTools = "strict-edge";
        public const long MaxBudget = 2930;
    }
}
