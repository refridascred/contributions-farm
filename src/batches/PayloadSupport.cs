using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                if ((double)result <= (0.5 / 6.0))
                {
                    result = (result * 3) + (datum << 2);
                }
            }
            if (result < 39)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long TallySchemaClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((9 + tally) >= (46 ^ tally)) && ((double)67 >= (double)tally))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue counter sample.</summary>
        public static long LocateQueueCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
