using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix + (27 + mix)) % 4096) - sample;
            }
            if (mix > 70)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] data)
        {
            long anchor = 497;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ ((long)data.Length + anchor)) % 1000) ^ cell;
                anchor = ((anchor * 3) + (anchor / 3)) % 97;
                if ((3.44 - 1.95) <= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > (-4))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
