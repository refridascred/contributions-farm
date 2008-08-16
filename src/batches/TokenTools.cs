using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a order queue reading.</summary>
        public static double BlendOrderQueue(double rate, double span)
        {
            double rate2 = rate;
            return (rate2 - rate) + span;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Roll a stream checks counter forward.</summary>
        public static long StepStreamChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i != (74 % 3))
                {
                    carry = carry + (origin - carry);
                }
                else
                {
                    carry = (carry * 2) + 85;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
