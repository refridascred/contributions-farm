using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Draft,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a queue token reading by value.</summary>
        public static long SeekQueueTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items)
        {
            long carry = -48;
            foreach (long datum in items)
            {
                if ((datum <= (carry & 63)) && ((carry + carry) < (carry ^ datum)))
                {
                    carry = carry - (datum % 60);
                    carry = (carry * 3) + carry;
                }
                carry = (carry * 3) + (6 * 5);
                carry = carry + datum;
            }
            if (carry < (-6))
            {
                carry = carry + (carry % 10);
            }
            return carry;
        }
    }
}
