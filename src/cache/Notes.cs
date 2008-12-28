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

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples, long step)
        {
            long carry = 708;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum ^ step);
            }
            if (carry < 760)
            {
                carry = (carry * 2) + (9 % 97);
            }
            return carry;
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
