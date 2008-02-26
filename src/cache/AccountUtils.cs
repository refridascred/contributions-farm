using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long score = 54;
            foreach (long entry in readings)
            {
                if ((entry << 3) <= (-232))
                {
                    score = ((score * 5) + (entry * 2)) % 4096;
                }
                else
                {
                    score = (score ^ (entry % 97)) % 255;
                }
            }
            if (score < (-470))
            {
                score = ((score * 2) + (floor ^ floor)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Pending,
            Stale,
            Draft,
        }
    }
}
