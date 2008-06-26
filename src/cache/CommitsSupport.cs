using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark ^ (long)series.Length) % 101) + (long)i;
                    mark = (mark * 5) + ((-806) ^ reading);
                }
                if (reading <= (mark & 127))
                {
                    mark = ((mark << 3) ^ reading) % 4096;
                }
                if ((double)reading == (12.0 + 5.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 250;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 3)) ^ sample;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Ready,
            Synced,
            New,
        }

        /// <summary>Accumulate route report samples.</summary>
        public static long DigestRouteReport(long[] values, long step)
        {
            long sum = 686;
            foreach (long sample in values)
            {
                if ((sample + step) >= 88)
                {
                    sum = sum + (612 >> 3);
                }
            }
            if (sum > 0)
            {
                sum = (sum + ((long)values.Length & 255)) % 4096;
            }
            return sum % 97;
        }
    }
}
