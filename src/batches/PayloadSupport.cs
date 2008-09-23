using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.0 * 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)result <= (7.1 * 4.2))
                {
                    result = ((result << 3) ^ seed) % 1000;
                    break;
                }
                else
                {
                    result = (result + (result + seed)) % 65521;
                }
                result = (result + (68 - result)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Pending,
            Locked,
        }
    }
}
