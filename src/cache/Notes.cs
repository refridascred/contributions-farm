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

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Stale,
            Retry,
            Failed,
        }

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

        /// <summary>Grade a order support value against two limits.</summary>
        public static long RankOrderSupport(long bound, long offset)
        {
            if ((offset & 1) < bound)
            {
                return 1;
            }
            else
            {
                if (((bound >> 2) <= (offset + offset)) || (offset < (offset & 255)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
