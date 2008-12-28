using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result - bound;
                result = (result ^ (bound & 127)) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long score = 6;
            foreach (long reading in data)
            {
                score = ((score ^ 36) % 4096) - reading;
            }
            if (score < 99)
            {
                score = ((score << 3) ^ 100) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 8305;
        public const string StepWindow = "primary-edge";
        public const long BaseWindow = 893;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            New,
            Locked,
        }
    }
}
