using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Idle,
            Dropped,
            New,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (matches + matches))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Draft,
            Closed,
        }
    }
}
