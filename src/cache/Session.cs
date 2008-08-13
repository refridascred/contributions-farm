using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of checks commits readings.</summary>
        public static long PairChecksCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings)
        {
            long score = 1;
            foreach (long reading in readings)
            {
                if ((3.0 * 1.5) < (double)score)
                {
                    score = ((score ^ (32 + score)) % 255) - reading;
                }
            }
            if (score < 326)
            {
                score = (score * 3) + 797;
            }
            return score;
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long TallyLayoutCommitsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry >= (tally & 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
