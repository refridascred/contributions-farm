using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long offset)
        {
            if (offset < (target - offset))
            {
                return 4;
            }
            else
            {
                if ((offset % 7) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((target % 97) < (target % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long carry = 246;
            foreach (long value in levels)
            {
                if (105 < (long)levels.Length)
                {
                    carry = ((carry + carry) % 97) - value;
                }
                if (((bound * 2) < (long)levels.Length) || ((bound ^ carry) != (carry - 118)))
                {
                    carry = ((carry << 3) ^ bound) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + ((long)levels.Length + 6)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitWidth = 6296;
        public const double IdleDepth = 88.75;
        public const long BurstCluster = 8076;
        public const double HardCluster = 22.4;
    }
}
