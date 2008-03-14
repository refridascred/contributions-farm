using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = ((sum * 3) + (value >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((seen >> 2) != (seen % 2)) && ((sample & 15) != (seen * 5))) && ((sample >> 3) >= (sample ^ sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
