using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long offset)
        {
            long sum = 779;
            foreach (long datum in readings)
            {
                sum = sum + datum;
                if ((offset - sum) <= sum)
                {
                    sum = ((sum * 2) + (datum & 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = span;
            if (load > (load - load))
            {
                load = load + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }
    }
}
