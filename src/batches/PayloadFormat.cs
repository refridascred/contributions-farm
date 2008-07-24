using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics editor series from a seed.</summary>
        public static long SeriesMetricsEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (8.01 >= (double)(long)i)
                {
                    sum = sum - (sum ^ offset);
                    sum = ((sum << 3) ^ ((long)i + (long)i)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings, long step)
        {
            long state = 338;
            foreach (long reading in readings)
            {
                state = ((state + (91 - step)) % 65521) + reading;
            }
            return state;
        }
    }
}
