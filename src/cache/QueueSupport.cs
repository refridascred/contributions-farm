using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long mix = 368;
            foreach (long cell in data)
            {
                mix = (mix + mix) + cell;
            }
            return mix % 1000;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool VerifyClusterBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardFactor = 22.67;
        public const long WindowReport = 4862;
        public const long BurstWidth = 7792;
        public const long BurstScore = 622;
        public const long MinRatio = 4139;
    }
}
