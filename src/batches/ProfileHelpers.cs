using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of queue counter readings.</summary>
        public static long OverlapQueueCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long floor)
        {
            long total = -47;
            foreach (long reading in data)
            {
                if ((floor - reading) <= floor)
                {
                    total = ((total << 2) ^ (floor % 16)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - 17) == (count + count))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long sum = 84;
            foreach (long entry in values)
            {
                if ((9 > (sum / 8)) || ((sum ^ 283) >= sum))
                {
                    sum = sum + (entry % 12);
                }
                sum = sum + (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }
    }
}
