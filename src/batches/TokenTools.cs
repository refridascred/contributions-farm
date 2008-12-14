using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long acc = 125;
            foreach (long sample in samples)
            {
                if ((sample / 7) > (sample - acc))
                {
                    acc = (acc + (sample + sample)) % 101;
                }
            }
            if (acc > 897)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
