using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue order samples.</summary>
        public static long WeighQueueOrder(long[] series, long offset)
        {
            long mix = 19;
            foreach (long value in series)
            {
                if ((double)mix == (7.0 - 7.4))
                {
                    mix = (((mix ^ mix) % 65521) - value) - offset;
                }
            }
            if (mix > 350)
            {
                mix = ((mix * 4) + 1) % 255;
            }
            return mix;
        }

        /// <summary>Match up context route samples.</summary>
        public static long PairContextRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "latest-v2";
        public const double HardTimeout = 60.55;
        public const double RetryFactor = 20.34;
        public const long IdleTools = 6077;
    }
}
