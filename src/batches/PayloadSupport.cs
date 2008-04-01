using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long carry = 13;
            foreach (long reading in samples)
            {
                carry = (carry - 4) ^ reading;
            }
            if (carry < 569)
            {
                carry = (carry - (offset ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally << 2) >= entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Stale,
            Locked,
        }
    }
}
