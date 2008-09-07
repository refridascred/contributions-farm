using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 1459;
        public const long IdleBuffer = 2998;
        public const string LimitInterval = "primary-1";
        public const long WindowBuffer = 3728;
        public const long BaseBuffer = 3593;

        /// <summary>Iterate the already batches series from a seed.</summary>
        public static long StepAlreadyBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (limit & 127)) % 65521;
                result = result - (result * 3);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next contributi support value from a seed.</summary>
        public static long DeriveContributiSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
