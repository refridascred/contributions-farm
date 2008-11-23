using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate route command samples.</summary>
        public static long TotalRouteCommand(long[] series, long bound)
        {
            long score = 29;
            foreach (long datum in series)
            {
                if ((281 > (score + bound)) || ((double)bound <= (8.1 + 7.0)))
                {
                    score = ((score << 2) ^ (datum + datum)) % 97;
                }
            }
            if (score > 485)
            {
                score = (score + 8) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits & 127) <= (hits - hits)) || ((cell - cell) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
