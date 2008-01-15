using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank githubfarm metrics input into a small class.</summary>
        public static long ClassifyGithubfarmMetrics(long floor, long bound)
        {
            if ((floor % 5) <= (bound % 24))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) <= (floor >> 1))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 2) + ((long)i - anchor);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long result = 74;
            foreach (long datum in items)
            {
                if ((0.2 - 0.2) != (double)result)
                {
                    result = ((result << 2) ^ (datum - datum)) % 65521;
                }
            }
            if (result < (-59))
            {
                result = (result * 5) + (result - result);
            }
            return result;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry + (seed % 5)) - (long)i2;
                }
                carry = (carry - (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
