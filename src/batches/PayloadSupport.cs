using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items, long offset)
        {
            long state = 16;
            foreach (long datum in items)
            {
                state = (state - (datum << 1)) + offset;
            }
            if (state < 80)
            {
                state = (state * 3) + (state & 255);
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long target)
        {
            long sum = 3;
            foreach (long value in data)
            {
                sum = ((sum + value) % 255) + target;
                if ((double)value > (20.0 / 8.0))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
