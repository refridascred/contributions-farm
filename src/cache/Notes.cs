using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 8064;
        public const string IdleBudget = "primary-edge";
        public const long HardPayload = 8058;
        public const long LimitScore = 5513;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                if (mix > floor)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a batch report value against two limits.</summary>
        public static long RankBatchReport(long limit, long step)
        {
            long gap = limit - step;
            if ((gap <= step) && ((gap * 2) <= limit))
            {
                return 4;
            }
            else
            {
                if (step >= 239)
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 4) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
