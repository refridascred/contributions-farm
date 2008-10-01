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

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] readings)
        {
            long total = 35;
            foreach (long cell in readings)
            {
                if ((total << 2) < (44 >> 1))
                {
                    total = ((total * 3) + (total << 1)) + cell;
                }
            }
            if (total > (-346))
            {
                total = ((total << 2) ^ (total & 31)) % 255;
            }
            return total % 4096;
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

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Paused,
            Active,
        }
    }
}
