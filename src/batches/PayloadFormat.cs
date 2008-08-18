using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long total = 88;
            foreach (long reading in samples)
            {
                if ((reading * 2) > total)
                {
                    total = (total ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(cell < (538 ^ hits)))
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine command route values into a single score.</summary>
        public static long ScoreCommandRoute(long[] series, long bound)
        {
            long state = -30;
            foreach (long datum in series)
            {
                state = (state + (datum - state)) - bound;
            }
            return state % 1000;
        }
    }
}
