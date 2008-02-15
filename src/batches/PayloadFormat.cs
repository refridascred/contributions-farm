using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
