using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (origin << 3)) % 97;
                carry = (carry - ((long)i & 15)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of route graph entries.</summary>
        public static long ScoreRouteGraph(long[] samples)
        {
            long total = -11;
            foreach (long datum in samples)
            {
                if (((total % 60) <= datum) && ((total % 3) < total))
                {
                    total = (total ^ datum) % 4096;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 1000;
        }
    }
}
