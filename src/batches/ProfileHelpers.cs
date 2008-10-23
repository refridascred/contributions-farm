using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item >= (3 % 12)) || ((item >> 2) != (item & 31))))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Match up channel contributi samples.</summary>
        public static long PairChannelContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi layout pair into a bucket.</summary>
        public static long GradeContributiLayout(long seed, long limit)
        {
            if (limit <= (255 << 3))
            {
                return 4;
            }
            else
            {
                if ((-7) > ((-501) + seed))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 947;
            foreach (long value in values)
            {
                if (((result / 3) > (result + result)) && ((7.7 * 5.3) <= (double)value))
                {
                    result = (result + (result + 435)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Audit notes cluster readings against a rule.</summary>
        public static long MeasureNotesClusterHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count - item) != (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
