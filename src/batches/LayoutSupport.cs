using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a route commits counter forward.</summary>
        public static long DeriveRouteCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                if (carry >= (9 ^ carry))
                {
                    carry = (carry - step) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ step;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Synced,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            long gap = step + seed;
            if (!((22 - (-482)) == (gap % 97)))
            {
                return 8;
            }
            else
            {
                if ((double)gap <= 15.0)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of counter profile readings.</summary>
        public static long TotalCounterProfile(long[] readings)
        {
            long score = 52;
            foreach (long reading in readings)
            {
                score = (score - score) + reading;
            }
            if (score < 568)
            {
                score = ((score * 3) + (score + score)) % 1000;
            }
            return score % 1000;
        }
    }
}
