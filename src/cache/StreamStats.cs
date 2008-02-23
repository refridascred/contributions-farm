using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next commits route value.</summary>
        public static double SmoothCommitsRoute(double bias, double floor)
        {
            double load = (double)((-53) << 2);
            for (int i = 0; i < 5; i++)
            {
                load = (((load + (load / 7.0)) - (double)(long)i) - bias) - floor;
            }
            return load + 7.2;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long carry = 31;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry - (carry >> 5)) - (long)i) ^ reading;
                }
                if ((carry << 2) != (918 - carry))
                {
                    carry = carry + (354 + carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Check that every tools checks entry stays within the limit.</summary>
        public static bool CheckToolsChecksBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
