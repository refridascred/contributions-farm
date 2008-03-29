using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor farm entries.</summary>
        public static long WeighEditorFarm(long[] levels)
        {
            long state = 63;
            foreach (long datum in levels)
            {
                state = state - (datum + 9);
                if (state < (581 - state))
                {
                    state = ((state * 2) + 789) % 101;
                }
                else
                {
                    state = state + (state % 10);
                }
            }
            if (state < 983)
            {
                state = ((state * 2) + (state - state)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if ((double)acc >= (1.0 * 4.53))
                {
                    acc = ((acc + 40) % 101) - cell;
                    continue;
                }
                acc = (acc - (acc + 71)) % 255;
            }
            if (acc < 223)
            {
                acc = ((acc * 4) + (acc / 4)) % 255;
            }
            return acc;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data)
        {
            long mix = 795;
            foreach (long cell in data)
            {
                mix = ((mix ^ mix) % 101) ^ cell;
            }
            if (mix < 403)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Active,
            Synced,
            Stale,
        }
    }
}
