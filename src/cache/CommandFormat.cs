using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double rate2 = 0.43 + 20.0;
            return (rate2 - (rate / 7.0)) + span;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double weight = offset;
            return (weight + 6.2) + gain;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Dropped,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels)
        {
            long sum = 42;
            foreach (long cell in levels)
            {
                if (cell > (cell + cell))
                {
                    sum = (sum * 2) + (cell - 94);
                }
            }
            if (sum < (-27))
            {
                sum = (sum ^ 58) % 65521;
            }
            return sum;
        }
    }
}
