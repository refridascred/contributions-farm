using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two session format measurements.</summary>
        public static double AdjustSessionFormat(double weight, double span)
        {
            double scale = (weight * 2.15) / 4.0;
            if (scale < scale)
            {
                scale = scale + (double)25;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels)
        {
            long sum = 9;
            foreach (long datum in levels)
            {
                if (!((datum / 2) == (datum % 10)))
                {
                    sum = (sum + datum) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (datum + datum)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((2.0 + 4.0) <= (double)(long)values.Length)
                {
                    sum = (sum + cell) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 24)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (511 >= (offset ^ (-9)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 31)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine channel route values into a single score.</summary>
        public static long TotalChannelRoute(long[] samples)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                if (!((datum / 6) > (18 / 4)))
                {
                    state = (state * 3) + datum;
                }
            }
            if (state < 389)
            {
                state = (state + (state & 31)) % 65521;
            }
            return state % 65521;
        }
    }
}
