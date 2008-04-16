using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                carry = ((carry + (85 >> 5)) % 101) - offset;
                if ((carry + (long)samples.Length) < 30)
                {
                    carry = ((carry << 3) ^ (value - value)) % 65521;
                }
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long origin, long step)
        {
            if (origin < (step - origin))
            {
                return 3;
            }
            else
            {
                if ((1.47 + 16.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
