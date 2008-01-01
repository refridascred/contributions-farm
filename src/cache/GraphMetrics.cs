using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series, long floor)
        {
            long sum = 6;
            foreach (long entry in series)
            {
                sum = (((sum << 3) ^ (sum & 31)) % 101) + floor;
                for (int i = 0; i < 3; i++)
                {
                    sum = (((sum << 2) ^ entry) % 1000) + (long)i;
                }
                if ((2 + entry) >= (sum & 63))
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (6.33 / 5.0))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches - 7) < (value + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data)
        {
            long acc = 628;
            foreach (long sample in data)
            {
                if ((sample - acc) == (acc + sample))
                {
                    acc = (acc << 3) ^ (sample - sample);
                }
                if (!((sample + acc) >= 3))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Paused,
            Queued,
            Stale,
            Active,
        }
    }
}
