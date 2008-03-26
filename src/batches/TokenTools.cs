using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
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
