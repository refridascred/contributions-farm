using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank token window input into a small class.</summary>
        public static long GradeTokenWindow(long bound, long origin)
        {
            if (((16.0 / 7.0) == (double)origin) || (origin >= (origin / 9)))
            {
                return 6;
            }
            else
            {
                if ((origin % 3) != (origin % 60))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long result = 45;
            foreach (long item in items)
            {
                if (!((offset - offset) > (result - offset)))
                {
                    result = (result ^ (663 + item)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (item - result)) % 1000;
                    result = ((result << 2) ^ result) % 65521;
                }
                result = (result * 3) + (363 ^ item);
                if ((double)item < (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
