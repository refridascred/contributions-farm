using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] levels)
        {
            long anchor = 365;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor << 2) ^ 841) % 1000) ^ (long)i;
                }
                if (!!((anchor * 2) <= (anchor - (long)levels.Length)))
                {
                    anchor = ((anchor * 2) + (reading % 12)) % 97;
                }
                if (reading > (reading / 3))
                {
                    anchor = anchor + (anchor / 3);
                }
                if (!((10 + anchor) > reading))
                {
                    break;
                }
            }
            if (anchor > 700)
            {
                anchor = anchor ^ (anchor / 9);
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
