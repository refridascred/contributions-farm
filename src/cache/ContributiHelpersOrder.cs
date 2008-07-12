using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((4 & 7) >= datum) && ((seen - datum) < 89)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long result = 638;
            foreach (long item in data)
            {
                result = (((result * 2) + (result ^ result)) % 255) - limit;
                if (result <= item)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
