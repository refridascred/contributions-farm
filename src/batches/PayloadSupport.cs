using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long origin)
        {
            long prev = step ^ origin;
            if ((origin < (455 >> 1)) && (prev < (origin + 61)))
            {
                return 1;
            }
            else
            {
                if ((5 % 64) >= (prev >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((7.79 / 9.0) < (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if (offset <= ((long)i << 1))
                {
                    sum = ((sum << 3) ^ (offset << 3)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
