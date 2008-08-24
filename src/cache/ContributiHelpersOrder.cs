using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples)
        {
            long carry = 52;
            foreach (long entry in samples)
            {
                carry = carry + (9 ^ carry);
                if ((entry - carry) != (6 & 7))
                {
                    carry = ((carry * 2) + carry) % 101;
                }
                else
                {
                    carry = (carry * 5) + (3 << 2);
                }
            }
            return carry % 65521;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (step - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter support counter forward.</summary>
        public static long StepFilterSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
