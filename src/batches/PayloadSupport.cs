using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings, long limit)
        {
            long mix = 43;
            foreach (long reading in readings)
            {
                mix = ((mix ^ mix) % 1000) - limit;
                if (7.14 > (double)reading)
                {
                    mix = ((mix << 2) ^ (reading % 24)) % 65521;
                }
                else
                {
                    mix = (mix ^ (reading - mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
