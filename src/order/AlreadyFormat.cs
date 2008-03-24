using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long step)
        {
            long lane = seed - step;
            if ((double)step >= (5.15 - 3.87))
            {
                return 7;
            }
            else
            {
                if ((double)lane >= (2.6 * 3.1))
                {
                    return 3;
                }
                else
                {
                    if (step >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long offset)
        {
            long result = 76;
            foreach (long reading in samples)
            {
                if ((offset % 3) == (result + result))
                {
                    result = ((result + ((-71) + offset)) % 4096) + reading;
                    result = (result - (offset - result)) % 4096;
                }
                result = ((result << 3) ^ (6 * 5)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxWidth = 1010;
        public const long LimitToken = 7583;
        public const long RetryToken = 4612;
        public const long BurstLevel = 385;
    }
}
