using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels, long limit)
        {
            long anchor = 922;
            foreach (long value in levels)
            {
                anchor = (anchor * 2) + (limit + 68);
                if (!(value > (limit / 8)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long carry = 589;
            foreach (long sample in items)
            {
                carry = ((carry << 2) ^ (sample & 7)) % 101;
                if ((double)(long)items.Length <= (9.0 / 8.0))
                {
                    carry = carry + (sample - sample);
                }
            }
            if (carry < 299)
            {
                carry = (carry ^ (carry ^ carry)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
