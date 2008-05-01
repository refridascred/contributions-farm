using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)seed == (2.0 - 2.4))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long origin)
        {
            if ((offset - origin) == (offset * 4))
            {
                return 2;
            }
            else
            {
                if ((origin % 97) >= (offset % 64))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 3) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double drift = (double)(787 - 66);
            if (drift < (weight + bias))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (6.7 + drift);
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Closed,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long anchor = 0;
            foreach (long reading in readings)
            {
                if ((1 * 3) >= anchor)
                {
                    anchor = ((anchor << 3) ^ (reading + anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
