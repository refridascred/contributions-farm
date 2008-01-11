using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long total = 72;
            foreach (long reading in series)
            {
                total = (total + total) % 1000;
                if ((reading + reading) >= (reading - total))
                {
                    total = total ^ (reading + reading);
                }
            }
            return total;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                sum = ((sum + (sum >> 5)) % 4096) + item;
                if (!((1 * 2) > (sum + sum)))
                {
                    sum = (sum + ((long)readings.Length - sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
