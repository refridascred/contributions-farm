using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool ValidateContextCommandRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0.51 / 6.0) > (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
