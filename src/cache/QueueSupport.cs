using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long carry = 97;
            foreach (long datum in data)
            {
                carry = ((carry * 2) + ((long)data.Length & 15)) + datum;
            }
            return carry % 65521;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Closed,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Adjust a session entry reading.</summary>
        public static double SmoothSessionEntry(double scale, double bias)
        {
            double mean = scale;
            if (mean >= mean)
            {
                mean = (mean - scale) + bias;
            }
            return mean + (double)904;
        }
    }
}
