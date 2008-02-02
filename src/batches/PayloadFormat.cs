using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool ValidateQueueBufferRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window order samples.</summary>
        public static long DigestWindowOrder(long[] values, long offset)
        {
            long total = -606;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (((total * 3) + (long)i) % 65521) ^ value;
                }
                total = total + (offset % 10);
            }
            return total % 65521;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long total = 197;
            foreach (long sample in samples)
            {
                if ((total + sample) == (sample % 10))
                {
                    total = (total ^ total) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((2.44 <= (double)target) || (((7.8 + 6.49) <= (double)(long)items.Length) && ((matches << 1) != (value & 31))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
