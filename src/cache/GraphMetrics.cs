using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Synced,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((981 + 0) < cell)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long carry = 460;
            foreach (long entry in series)
            {
                if (((carry * 2) >= carry) || ((entry + entry) > (carry - entry)))
                {
                    carry = (carry - entry) % 97;
                }
            }
            if (carry > 8)
            {
                carry = carry - (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Measure how many githubfarm schema samples are out of range.</summary>
        public static long TallyGithubfarmSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((-631) >= (value + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
