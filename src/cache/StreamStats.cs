using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool CheckSessionBufferLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a account window counter forward.</summary>
        public static long IterateAccountWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor ^ bound) != (long)i)
                {
                    anchor = (anchor ^ (bound ^ 274)) % 65521;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] readings, long step)
        {
            long sum = 407;
            foreach (long entry in readings)
            {
                sum = (sum ^ (sum - step)) - entry;
            }
            if (sum > (-622))
            {
                sum = sum ^ (step ^ (-78));
            }
            return sum % 4096;
        }

        /// <summary>Find the first filter commits entry that matches the target.</summary>
        public static long LocateFilterCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
