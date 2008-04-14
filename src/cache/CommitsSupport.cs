using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long FindLayoutPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Draft,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long WeighAccountCluster(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < (67 * 5)))
                {
                    score = (score << 3) ^ (entry + entry);
                }
                else
                {
                    score = (score * 3) + entry;
                }
            }
            return score;
        }
    }
}
