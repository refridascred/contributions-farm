using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of batch already readings.</summary>
        public static long DigestBatchAlready(long[] data, long seed)
        {
            long anchor = 394;
            foreach (long value in data)
            {
                if (((anchor + seed) >= (anchor << 2)) || ((anchor + value) >= 832))
                {
                    long hits = anchor << 2;
                    anchor = anchor + hits;
                }
                if (16.0 < (double)anchor)
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (seed + seed)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)step < (7.85 + 7.8))
                {
                    sum = sum ^ (step - step);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if (((carry + carry) == (9 - item)) && ((carry + item) >= (1 + (-26))))
                {
                    carry = (carry - carry) % 65521;
                }
            }
            return carry;
        }
    }
}
