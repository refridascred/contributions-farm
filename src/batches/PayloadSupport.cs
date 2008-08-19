using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series)
        {
            long anchor = -6;
            foreach (long datum in series)
            {
                anchor = (anchor ^ (anchor + datum)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples, long step)
        {
            long carry = 2;
            foreach (long reading in samples)
            {
                if (6.0 > (double)reading)
                {
                    carry = carry + carry;
                }
                if ((step - carry) == (reading % 5))
                {
                    carry = carry - (reading >> 5);
                }
            }
            if (carry > 101)
            {
                carry = ((carry << 2) ^ (step & 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
