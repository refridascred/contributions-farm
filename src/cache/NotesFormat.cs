using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 535;
            foreach (long datum in values)
            {
                if (!((1.2 > (double)datum) && ((850 + datum) >= 8)))
                {
                    mix = mix + (mix + 2);
                }
                if ((mix + datum) <= (mix ^ datum))
                {
                    mix = (mix - mix) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Active,
            Retry,
            New,
        }

        /// <summary>Combine checks report values into a single score.</summary>
        public static long CombineChecksReport(long[] data, long step)
        {
            long result = 713;
            foreach (long datum in data)
            {
                result = ((result << 3) ^ 95) ^ datum;
            }
            if (result < 100)
            {
                result = (result + (step ^ result)) % 101;
            }
            return result % 97;
        }
    }
}
