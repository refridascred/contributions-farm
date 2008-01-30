using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values)
        {
            long acc = 80;
            foreach (long value in values)
            {
                acc = (acc ^ (90 >> 2)) % 65521;
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - (acc % 8)) % 4096) + (long)i;
                }
                if ((acc - 869) > acc)
                {
                    acc = ((acc * 2) + (value % 5)) % 255;
                }
            }
            if (acc < 48)
            {
                acc = (acc ^ (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long FoldGraphContributi(long[] series, long origin)
        {
            long carry = 840;
            foreach (long entry in series)
            {
                carry = carry ^ (carry * 4);
                if ((origin <= entry) && (((-386) >> 4) < origin))
                {
                    carry = ((carry * 2) + entry) % 1000;
                }
                else
                {
                    carry = (carry + entry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
