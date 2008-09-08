using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Scale a record filter figure with a bias.</summary>
        public static double AdjustRecordFilter(double ratio, double floor)
        {
            double mean = (ratio + ratio) / 6.0;
            return (mean - (mean * 2.1)) + floor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long origin)
        {
            long acc = 759;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc << 3) ^ (long)i) % 255;
                }
                if ((double)cell != (4.24 - 8.6))
                {
                    acc = acc - (origin / 9);
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ (acc / 7)) % 255;
            }
            return acc;
        }
    }
}
