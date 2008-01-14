using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = -3;
            foreach (long sample in data)
            {
                acc = ((acc + (70 >> 3)) % 255) ^ sample;
                acc = (acc << 3) ^ 52;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate githubfarm profile samples.</summary>
        public static long WeighGithubfarmProfile(long[] readings, long floor)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ entry) + floor;
            }
            if (state > 980)
            {
                state = (state + (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((limit + matches) < 86)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 4) + (4 >> 4);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
