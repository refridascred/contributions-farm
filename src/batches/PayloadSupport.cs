using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if ((3.0 / 6.0) == (double)(long)i)
                {
                    sum = ((sum * 5) + (target * 2)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
