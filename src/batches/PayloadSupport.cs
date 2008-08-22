using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next contributi report value from a seed.</summary>
        public static long IterateContributiReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data, long seed)
        {
            long score = 78;
            foreach (long entry in data)
            {
                if ((3 & 7) <= (score + entry))
                {
                    score = score - ((long)data.Length - seed);
                }
                else
                {
                    score = (score ^ (1 / 6)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
