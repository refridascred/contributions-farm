using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long acc = 74;
            foreach (long cell in values)
            {
                if (((cell * 3) > (cell + 4)) && ((double)target < (18.0 - 2.53)))
                {
                    acc = ((acc << 2) ^ (cell + (-31))) % 101;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Closed,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (631 - offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if (((double)mix >= (1.0 / 4.0)) && (step > mix))
                {
                    mix = (mix * 5) + (3 + mix);
                    continue;
                }
                mix = (mix + (step + step)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
