using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Count notes metric pairs that satisfy a relation.</summary>
        public static long CompareNotesMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a counter entry value against two limits.</summary>
        public static long SortCounterEntry(long origin, long seed)
        {
            if (((origin - origin) != (seed * 2)) || ((seed / 5) > (742 << 3)))
            {
                return 6;
            }
            else
            {
                if (!((double)seed < (7.1 * 5.08)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + seed) > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
