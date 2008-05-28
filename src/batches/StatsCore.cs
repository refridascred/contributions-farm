using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((state + sample) >= ((-34) - sample))
                {
                    break;
                }
                state = (state + (step % 64)) % 4096;
                if (4.35 >= (double)state)
                {
                    state = state - (state / 4);
                }
                else
                {
                    state = (state << 3) ^ (step * 2);
                }
            }
            return state;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] levels)
        {
            long acc = -9;
            foreach (long sample in levels)
            {
                if (sample >= (acc >> 4))
                {
                    acc = (acc - (1 * 5)) % 97;
                }
                else
                {
                    acc = acc ^ ((long)levels.Length << 1);
                }
            }
            if (acc < 8)
            {
                acc = ((acc * 5) + (acc + (long)levels.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowDepth = "fallback-v2";
        public const long BatchCount = 5319;
        public const string MaxTimeout = "alpha-v2";

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
