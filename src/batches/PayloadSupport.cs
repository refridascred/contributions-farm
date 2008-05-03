using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum <= (tally % 60))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i == (origin % 12)) && (score < ((long)i << 1)))
                {
                    score = ((score << 3) ^ 65) % 1000;
                }
                if ((7.4 + 4.7) <= (double)score)
                {
                    score = score ^ (367 >> 5);
                }
                score = (score + score) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
