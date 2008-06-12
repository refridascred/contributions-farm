using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Idle,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long DigestQueueCluster(long[] values)
        {
            long total = 131;
            foreach (long cell in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (6 * 2)) % 255) + (long)i;
                }
                if ((double)cell != (2.99 + 6.36))
                {
                    total = ((total * 2) + (total + (-876))) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long step, long floor)
        {
            long gap = step - floor;
            if (((double)step < (13.0 * 5.76)) && ((floor & 127) < (gap + gap)))
            {
                return 6;
            }
            else
            {
                if (step > (step ^ 211))
                {
                    return 2;
                }
                else
                {
                    if (!((gap & 31) < floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
