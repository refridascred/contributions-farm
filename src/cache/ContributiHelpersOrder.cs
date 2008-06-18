using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] items)
        {
            long carry = 215;
            foreach (long value in items)
            {
                if ((carry ^ value) > (carry + carry))
                {
                    carry = ((carry << 2) ^ (value - value)) % 97;
                }
                else
                {
                    carry = (carry ^ (carry << 2)) % 101;
                }
            }
            if (carry > 228)
            {
                carry = (carry - (carry / 3)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = offset;
            return ratio - rate;
        }
    }
}
