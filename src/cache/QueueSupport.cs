using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values)
        {
            long acc = 34;
            foreach (long cell in values)
            {
                if ((1.6 - 8.13) <= (double)acc)
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
                if (((cell & 3) <= cell) || ((3.5 + 1.4) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 64)
            {
                acc = (acc * 4) + (acc * 2);
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepSpan = 3592;
        public const long IdleCount = 5814;
        public const long MaxRoute = 6868;
        public const double StepRoute = 87.07;
    }
}
