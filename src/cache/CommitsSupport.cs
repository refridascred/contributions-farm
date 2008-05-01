using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long SortStatsQueue(long step, long target)
        {
            long diff = step + target;
            if (!((diff - 7) < step))
            {
                return 5;
            }
            else
            {
                if ((94 / 3) > diff)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long MeasureLayoutWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches >= (19.0 * 9.0))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long floor)
        {
            long bound = origin ^ floor;
            if (bound > origin)
            {
                return 1;
            }
            else
            {
                if ((floor + origin) < (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if ((floor / 9) > (floor % 10))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
