using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (2.7 - 6.32))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm layout counter forward.</summary>
        public static long IterateGithubfarmLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step & 1) != (step - step))
                {
                    sum = ((sum * 4) + (123 - step)) % 97;
                    sum = (sum ^ (64 >> 3)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Closed,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool CheckCommandWindowRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
