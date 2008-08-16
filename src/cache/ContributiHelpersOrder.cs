using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long acc = 8;
            foreach (long datum in samples)
            {
                if ((acc >> 2) >= (acc + 112))
                {
                    acc = (acc * 5) + (datum ^ acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long offset)
        {
            long step = floor - offset;
            if ((floor * 4) == (step + step))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (3.9 + 2.51))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
