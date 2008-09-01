using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the support session series from a seed.</summary>
        public static long DeriveSupportSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result & 127);
                result = (result ^ (offset / 6)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Combine batch commits values into a single score.</summary>
        public static long DigestBatchCommits(long[] readings)
        {
            long acc = -14;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ (acc - 931)) % 65521;
                if ((acc & 255) > acc)
                {
                    acc = (acc * 4) + (acc + item);
                }
            }
            if (acc < (-19))
            {
                acc = (acc + (6 * 3)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Audit record cluster readings against a rule.</summary>
        public static long CountRecordClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell ^ cell) != (cell * 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long floor, long target)
        {
            long step = floor - target;
            if (((double)target == (8.6 - 11.0)) || (floor <= (floor + step)))
            {
                return 8;
            }
            else
            {
                if (!(target >= (62 - target)))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) == (step + target)) && ((5 + floor) <= 171))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
