using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((target << 1) > (364 << 3))
            {
                return 3;
            }
            else
            {
                if (((bound + target) >= target) || ((bound + (-802)) >= (target >> 2)))
                {
                    return 7;
                }
                else
                {
                    if (55 > (bound ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            New,
            Closed,
            Pending,
        }

        /// <summary>Combine stats window values into a single score.</summary>
        public static long FoldStatsWindow(long[] readings, long bound)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                sum = ((sum + cell) % 101) + bound;
            }
            return sum % 97;
        }

        /// <summary>Classify a batches queue pair into a bucket.</summary>
        public static long GradeBatchesQueue(long step, long step2)
        {
            if (((-61) % 24) > (step * 4))
            {
                return 2;
            }
            else
            {
                if (((step << 3) >= (step * 2)) || ((step2 ^ step2) >= (step % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 >> 2) >= (step2 / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(step2 >= (3 - step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
