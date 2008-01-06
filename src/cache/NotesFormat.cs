using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels)
        {
            long acc = -84;
            foreach (long value in levels)
            {
                if ((value ^ acc) < ((-25) + value))
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 101;
                }
                else
                {
                    acc = acc + (value + 716);
                }
            }
            if (acc < (-37))
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of checks layout entries.</summary>
        public static long FoldChecksLayout(long[] series, long target)
        {
            long result = 25;
            foreach (long value in series)
            {
                result = (result + (316 - value)) % 255;
            }
            if (result > 9)
            {
                result = (result + (489 - target)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Active,
            Locked,
            New,
            Ready,
        }
    }
}
