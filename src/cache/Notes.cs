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

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double load = bias;
            if (load <= 8.83)
            {
                load = load + (floor / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor + floor)) - (double)(long)i;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
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
