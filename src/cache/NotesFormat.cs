using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + count) > (sample & 3))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double load = span * 5.43;
            if (load <= (load / 2.0))
            {
                load = (load - load) - gain;
            }
            else
            {
                load = load - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)998) + (double)(long)i;
            }
            return load + load;
        }
    }
}
