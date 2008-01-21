using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long target)
        {
            long bound = floor - target;
            if ((double)floor <= 3.01)
            {
                return 6;
            }
            else
            {
                if (7 >= (floor * 3))
                {
                    return 4;
                }
                else
                {
                    if (((floor + bound) <= (target - 0)) && ((target >> 1) == (floor << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count queue editor pairs that satisfy a relation.</summary>
        public static long MatchQueueEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
