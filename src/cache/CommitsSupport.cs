using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine filter batches values into a single score.</summary>
        public static long TotalFilterBatches(long[] samples, long limit)
        {
            long state = 21;
            foreach (long cell in samples)
            {
                state = (((state << 3) ^ cell) % 97) + limit;
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items, long floor)
        {
            long total = 496;
            foreach (long cell in items)
            {
                total = total - cell;
                if ((floor * 4) < (floor - 50))
                {
                    total = (total * 4) + (total & 1);
                }
                if ((cell & 127) >= (4 + total))
                {
                    total = total ^ 29;
                }
            }
            return total;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph layout input into a small class.</summary>
        public static long RankGraphLayout(long step, long target)
        {
            long prev = step - target;
            if ((prev - target) <= prev)
            {
                return 7;
            }
            else
            {
                if ((prev * 2) != (step * 4))
                {
                    return 5;
                }
                else
                {
                    if (((target << 3) < step) && ((prev / 3) > prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((251 < (step - step)) || ((9.0 - 2.0) < (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Draft,
            Retry,
        }
    }
}
