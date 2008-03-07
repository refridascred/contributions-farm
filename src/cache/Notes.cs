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

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long limit)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                if ((entry * 5) > (94 + entry))
                {
                    carry = (((carry << 2) ^ entry) % 101) - limit;
                }
            }
            return carry % 65521;
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
