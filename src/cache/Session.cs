using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                sum = ((sum << 3) ^ (sum ^ (-9))) - entry;
                sum = sum ^ (sum * 5);
            }
            return sum;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long CountBufferSchemaHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((444 + datum) > (seed + tally)) && (5.0 < (double)datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
