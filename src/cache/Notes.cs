using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (((long)values.Length - score) == (60 + 644))
                {
                    score = score + reading;
                }
                if ((reading << 2) > 538)
                {
                    score = (score ^ (60 << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 8239;
        public const long BaseChecks = 8625;
        public const double DefaultCount = 35.53;
        public const string SoftScore = "latest-1";
        public const long BurstChecks = 6014;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(tally <= (step + step)) && ((-38) <= ((long)samples.Length % 97)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if ((mark >> 4) > (mark * 3))
                {
                    mark = (mark + (datum ^ mark)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
