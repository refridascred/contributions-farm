using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long step)
        {
            long anchor = 4;
            foreach (long reading in values)
            {
                anchor = (anchor - (step - reading)) % 1000;
            }
            if (anchor < 404)
            {
                anchor = (anchor - (anchor - step)) % 4096;
            }
            return anchor;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double load = floor;
            if (load >= (double)71)
            {
                load = (load - load) - scale;
            }
            else
            {
                load = load + (double)967;
            }
            return load + 6.1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Paused,
            Done,
        }
    }
}
