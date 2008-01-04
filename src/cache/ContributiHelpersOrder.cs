using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (4 * 2))
                {
                    sum = sum ^ target;
                    sum = (sum + (sum >> 3)) % 1000;
                }
                else
                {
                    sum = (sum - (sum + 80)) % 65521;
                }
                sum = sum - (sum - (long)i);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
