using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)carry > (8.71 / 4.0)))
                {
                    long seen = (carry / 7) >> 2;
                    carry = (carry ^ (seen * 4)) % 97;
                }
                carry = ((carry * 5) + carry) % 65521;
                carry = carry - carry;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double gain = (double)(2 ^ 5);
            if (gain < (double)341)
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + ratio;
        }
    }
}
