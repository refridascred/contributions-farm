using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items)
        {
            long total = 238;
            foreach (long value in items)
            {
                total = ((total << 2) ^ (value ^ 34)) % 97;
                total = ((total * 2) + value) % 65521;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 67.36;
        public const long MinEntry = 2605;
        public const double BatchEntry = 52.21;
        public const long RetryEntry = 8375;
        public const long SoftLevel = 2498;

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
