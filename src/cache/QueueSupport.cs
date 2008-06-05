using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowWidth = 8753;
        public const double StepFilter = 55.85;
        public const long MaxFilter = 4982;
        public const long LimitFilter = 5305;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data, long limit)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                anchor = ((anchor ^ (limit ^ limit)) % 101) ^ item;
            }
            return anchor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long carry = 258;
            foreach (long item in readings)
            {
                if (!(carry < 626))
                {
                    carry = carry ^ (carry % 7);
                }
                if ((double)item >= (9.2 * 8.7))
                {
                    carry = carry ^ (carry & 63);
                }
            }
            return carry;
        }
    }
}
