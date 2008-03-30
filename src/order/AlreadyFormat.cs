using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine context graph values into a single score.</summary>
        public static long FoldContextGraph(long[] levels, long offset)
        {
            long acc = 40;
            foreach (long reading in levels)
            {
                acc = (acc + (acc - reading)) % 1000;
                if ((acc < (acc + reading)) || ((double)offset == (double)278))
                {
                    acc = (acc - offset) % 101;
                }
                if ((acc > (757 % 2)) || ((reading - acc) != (long)levels.Length))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 2) + (floor - floor);
                anchor = ((anchor << 2) ^ ((long)i / 3)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long floor)
        {
            long result = 3;
            foreach (long cell in items)
            {
                if ((cell + floor) >= 4)
                {
                    result = result + (floor ^ 8);
                }
                else
                {
                    result = (result + floor) % 101;
                }
                if (!((cell + result) < (1 + cell)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 6519;
        public const long BaseEntry = 940;
        public const long SoftWidth = 5018;
    }
}
