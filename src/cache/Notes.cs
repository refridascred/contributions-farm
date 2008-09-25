using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count <= (count & 63)) || ((9.6 > (double)count) || ((count << 3) != (5 + cell))))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 5488;
        public const long LimitFactor = 4935;
        public const long BaseLevel = 8644;
        public const double StepWidth = 62.81;

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftRatio = "local-1";
        public const long LimitSchema = 6835;
        public const long WindowSchema = 9746;
        public const long BaseSchema = 9913;
        public const long CacheCount = 4977;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long carry = 305;
            foreach (long datum in readings)
            {
                if ((datum - datum) != (carry ^ carry))
                {
                    carry = carry - (carry + carry);
                }
                else
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            if (carry > 569)
            {
                carry = carry + (carry + 99);
            }
            return carry % 4096;
        }
    }
}
