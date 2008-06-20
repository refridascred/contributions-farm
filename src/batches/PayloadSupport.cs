using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 7) < tally)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 67;
            foreach (long item in values)
            {
                if ((long)values.Length > (423 & 3))
                {
                    mix = (mix - ((-70) << 1)) % 4096;
                    break;
                }
                else
                {
                    mix = ((mix * 5) + (item + 0)) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix << 3) ^ (item + item)) % 255) - (long)i;
                }
                if (((mix + item) != (item * 3)) && ((631 << 1) < (item & 1)))
                {
                    mix = ((mix << 3) ^ (item + (long)values.Length)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
