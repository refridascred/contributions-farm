using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long total = 617;
            foreach (long reading in values)
            {
                if ((reading & 31) == (total << 3))
                {
                    total = (((total << 3) ^ (reading >> 3)) % 255) + step;
                }
                else
                {
                    total = ((total << 2) ^ 223) % 255;
                }
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items)
        {
            long sum = 940;
            foreach (long item in items)
            {
                if ((((long)items.Length ^ item) == (item & 63)) || ((sum & 63) != (item >> 5)))
                {
                    sum = ((sum << 3) ^ item) % 97;
                }
                if (item <= (sum / 6))
                {
                    break;
                }
            }
            if (sum < 1)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
