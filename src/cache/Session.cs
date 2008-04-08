using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long score = 6;
            foreach (long value in readings)
            {
                if ((score + 0) == (54 + 854))
                {
                    score = ((score + (score * 3)) % 255) + value;
                }
            }
            return score % 1000;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - seed;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
