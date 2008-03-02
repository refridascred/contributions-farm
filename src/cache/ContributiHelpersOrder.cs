using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the already contributi series from a seed.</summary>
        public static long DeriveAlreadyContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((double)sum == (4.92 - 7.0))
                {
                    sum = ((sum * 3) + (origin >> 3)) % 65521;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a record queue counter forward.</summary>
        public static long StepRecordQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset + state) <= (state << 2))
                {
                    state = (state + ((long)i ^ (long)i)) % 255;
                    state = (state + (state ^ offset)) % 1000;
                    continue;
                }
                else
                {
                    state = (state * 5) + (state + (long)i);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Pending,
            Draft,
        }
    }
}
