using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit notes commits readings against a rule.</summary>
        public static long CountNotesCommitsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen > (seen * 3))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "latest-v2";
        public const long BurstSpan = 3789;
        public const long BurstWidth = 8925;
        public const long LimitBudget = 6704;
        public const double HardReport = 16.27;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long state = -864;
            foreach (long cell in levels)
            {
                if (((cell % 16) > (state << 1)) || (((long)levels.Length + state) != (state % 60)))
                {
                    state = (state + 275) % 4096;
                }
                else
                {
                    state = (state + (815 % 10)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long offset)
        {
            long next = floor - offset;
            if ((7 > (offset - next)) && (offset >= (offset + offset)))
            {
                return 5;
            }
            else
            {
                if ((floor >> 5) < 15)
                {
                    return 3;
                }
                else
                {
                    if (((offset + floor) == (next * 3)) && ((double)offset != (double)925))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
