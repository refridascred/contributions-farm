using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the metric route entries that pass the check.</summary>
        public static long CountMetricRouteGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(seen >= (sample * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
